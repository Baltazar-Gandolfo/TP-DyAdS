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
            RepartidorData data = new RepartidorData();
            data.AltaRepartidor(repartidor);
        }
        public void EliminarRepartidor(string id)
        {
            try
            {
                repartidorData.EliminarRepartidor(id);
            }
            catch
            {
                throw;
            }
        }

        public void EditarRepartidor(RepartidorEntity repartidor)
        {
            try
            {
                repartidorData.EditarRepartidor(repartidor);
            }
            catch
            {
                throw;
            }
        }
    }


}
