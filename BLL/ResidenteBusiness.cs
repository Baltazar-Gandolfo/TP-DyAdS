using DAO;
using Entities;
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
                return residenteData.getById(id);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
