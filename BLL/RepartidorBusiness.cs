using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepartidorBusiness
    {
        private RepartidorData repartidorData = new RepartidorData();

        public List<RepartidorEntity> getAll()
        {
            try
            {
                return repartidorData.getAll();
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
                return repartidorData.getById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AltaRepartidor(RepartidorEntity repartidor)
        {
            try
            {
                if (repartidor.Apellido == null || repartidor.Telefono == null || repartidor.Empresa == null || repartidor.Nombre == null || repartidor.Num_Legajo == null)
                {
                    throw new Exception("No se aceptan campos nulos.");
                }
                foreach (var rep in getAll())
                {
                    if (rep.Telefono == repartidor.Telefono)
                    {
                        throw new Exception("Este telefono ya esta en uso.");
                    }
                }
                repartidorData.AltaRepartidor(repartidor);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void EliminarRepartidor(string id)
        {
            try
            {
                if (getById(id) == null)
                {
                    throw new Exception("No se encontro el repartidor a eliminar.");
                }
                repartidorData.EliminarRepartidor(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EditarRepartidor(RepartidorEntity repartidor)
        {
            try
            {
                if (repartidor.Apellido == null || repartidor.Telefono == null || repartidor.Empresa == null || repartidor.Nombre == null || repartidor.Num_Legajo == null)
                {
                    throw new Exception("No se aceptan campos nulos.");
                }
                foreach (var rep in getAll())
                {
                    if (rep.Telefono == repartidor.Telefono)
                    {
                        throw new Exception("Este telefono ya esta en uso.");
                    }
                }
                repartidorData.EditarRepartidor(repartidor);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }


}
