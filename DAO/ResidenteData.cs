using DAO.Models;
using Entities;
using Entities.Models;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ResidenteData
    {
        public List<ResidenteEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var residentes = context.Residentes.ToList();
                    List<ResidenteEntity> residentesEntity = new List<ResidenteEntity>();
                    foreach (var residente in residentes)
                    {
                        residentesEntity.Add(ResidenteMapper.Map(residente));
                    }
                    return residentesEntity;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<ResidenteEntity> GetAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var recidente = context.Residentes
                        .Select(t => ResidenteMapper.Map(t))
                        .ToList();

                    return recidente;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ResidenteEntity GetById(string id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var residente = context.Residentes
                        .FirstOrDefault(r => r.ResidenteId == id);

                    return residente == null ? null : ResidenteMapper.Map(residente);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void AltaResidente(ResidenteEntity entity)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var model = ResidenteMapper.Map(entity);
                    context.Residentes.Add(model);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }



        public void Update(ResidenteEntity entity)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var residente = context.Residentes
                        .FirstOrDefault(r => r.ResidenteId == entity.Id);

                    if (residente == null)
                        throw new Exception("No se encontró el residente para actualizar.");

                    residente.Nombre = entity.Nombre;
                    residente.Apellido = entity.Apellido;
                    residente.Departamento = entity.Departamento;
                    residente.Telefono = entity.Telefono;
                    residente.Email = entity.Email;
                    residente.PrefNotif = entity.Pref_Notificacion;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Delete(string id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // 1. Buscar residente
                    var residente = context.Residentes.FirstOrDefault(r => r.ResidenteId == id);
                    if (residente == null)
                        throw new Exception("Residente no encontrado.");

                    // 2. Eliminar lockers asociados
                    var lockers = context.Lockers.Where(l => l.ResidenteId == id).ToList();
                    if (lockers.Any())
                    {
                        context.Lockers.RemoveRange(lockers);
                    }


                    // 4. Eliminar residente
                    context.Residentes.Remove(residente);

                    // 5. Guardar cambios
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
