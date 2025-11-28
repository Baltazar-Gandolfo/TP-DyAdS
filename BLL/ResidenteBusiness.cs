using DAO;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ResidenteBusiness
    {
        private ResidenteData residenteData = new ResidenteData();

        public List<ResidenteEntity> getAll()
        {
            try
            {
                return residenteData.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ResidenteEntity getById(string id)
        {
            try
            {
                return residenteData.GetById(id);
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
                if (string.IsNullOrWhiteSpace(entity.Nombre))
                    throw new Exception("El nombre es obligatorio.");
                if (entity.Apellido == null || entity.Telefono == null || entity.Nombre == null || entity.Departamento == null || entity.Email == null || entity.Pref_Notificacion == null)
                {
                    throw new Exception("No se aceptan campos nulos.");
                }
                foreach (var res in getAll())
                {
                    if (res.Email == entity.Email)
                    {
                        throw new Exception("Este mail ya esta en uso.");
                    }
                    if (res.Telefono == entity.Telefono)
                    {
                        throw new Exception("Este telefono ya esta en uso.");
                    }
                }
                residenteData.AltaResidente(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ActualizarResidente(ResidenteEntity entity)
        {
            try
            {
                if (entity.Apellido == null || entity.Telefono == null || entity.Nombre == null || entity.Departamento == null || entity.Email == null || entity.Pref_Notificacion == null)
                {
                    throw new Exception("No se aceptan campos nulos.");
                }
                foreach (var res in getAll())
                {
                    if(res.Id != entity.Id)
                    {
                        if (res.Departamento == entity.Departamento)
                        {
                            throw new Exception("Este departamento ya esta ocupado por otro residente. \nChequee el nr de departamento colocado.");
                        }
                        if (res.Email == entity.Email)
                        {
                            throw new Exception("Este mail ya esta en uso.");
                        }
                        if (res.Telefono == entity.Telefono)
                        {
                            throw new Exception("Este telefono ya esta en uso.");
                        }
                    }
                }
                residenteData.Update(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarResidente(string id)
        {
            try
            {
                if (getById(id) == null)
                {
                    throw new Exception("No se encontro el residente a eliminar.");
                }
                residenteData.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
