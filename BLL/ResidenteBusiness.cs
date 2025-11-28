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
            if (string.IsNullOrWhiteSpace(entity.Nombre))
                throw new Exception("El nombre es obligatorio.");

            residenteData.AltaResidente(entity);
        }

        public List<ResidenteEntity> ObtenerResidentes()
        {
            try
            {
                var residentes = residenteData.GetAll();
                return residentes;
            }
            catch (Exception ex) { throw; }

        }
        public void ActualizarResidente(ResidenteEntity entity)
        {
            try
            {
                residenteData.Update(entity);
            }
            catch
            {
                throw;
            }
        }

        public void EliminarResidente(string id)
        {
            try
            {
                residenteData.Delete(id);
            }
            catch
            {
                throw;
            }
        }

    }
}
