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
    public class RepartidorData
    {
        public List<RepartidorEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var repartidores = context.Repartidores.ToList();
                    List<RepartidorEntity> repartidoresEntity = new List<RepartidorEntity>();
                    foreach (var repartidor in repartidores)
                    {
                        repartidoresEntity.Add(RepartidorMapper.Map(repartidor));
                    }
                    return repartidoresEntity;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
      
      
        public RepartidorEntity getById(string id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var repartidor = context.Repartidores.FirstOrDefault(t => Convert.ToString(t.RepartidorId) == id);
                    if (repartidor != null)
                    {
                        return RepartidorMapper.Map(repartidor);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AltaRepartidor(RepartidorEntity entity)
        {
            using (var context = new AppDbContext())
            {
                Repartidore nuevo = new Repartidore()
                {
                    RepartidorId = entity.Id,
                    Nombre = entity.Nombre,
                    Apellido = entity.Apellido,
                    Empresa = entity.Empresa,
                    LegajoNumero = entity.Num_Legajo,
                    Telefono = entity.Telefono,
                    CredencialValida = entity.Credencial_Valida
                };

                context.Repartidores.Add(nuevo);
                context.SaveChanges();
            }
        }


        public void EliminarRepartidor(string id)
        {
            using (var context = new AppDbContext())
            {
                // 1. Buscar residente
                var repartidor = context.Repartidores.FirstOrDefault(r => r.RepartidorId == id);
                if (repartidor == null)
                    throw new Exception("Repartidor no encontrado.");

                // 2. Eliminar lockers asociados
                var lockers = context.Lockers.Where(l => l.RepartidorId == id).ToList();
                if (lockers.Any())
                {
                    context.Lockers.RemoveRange(lockers);
                }
                // 4. Eliminar residente
                context.Repartidores.Remove(repartidor);

                // 5. Guardar cambios
                context.SaveChanges();
            }
        }

        public void EditarRepartidor(RepartidorEntity rep)
        {
            using (var context = new AppDbContext())
            {
                var dbRep = context.Repartidores.FirstOrDefault(r => r.RepartidorId == rep.Id);

                if (dbRep == null)
                    throw new Exception("Repartidor no encontrado en la BD.");

                dbRep.Nombre = rep.Nombre;
                dbRep.Apellido = rep.Apellido;
                dbRep.Empresa = rep.Empresa;
                dbRep.LegajoNumero = rep.Num_Legajo;
                dbRep.Telefono = rep.Telefono;
                dbRep.CredencialValida = rep.Credencial_Valida;

                context.SaveChanges();
            }
        }


    }
}
