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

        public RepartidorEntity getById(int id)
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
    }
}
