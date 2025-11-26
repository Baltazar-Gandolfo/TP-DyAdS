using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LockerBusiness
    {
        private LockerData lockerData = new LockerData();
        private RepartidorBusiness repartidorBusiness = new RepartidorBusiness();
        private ResidenteBusiness residenteBusiness = new ResidenteBusiness();

        public List<LockerEntity> getAll()
        {
            try
            {
                return lockerData.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private LockerEntity getById(int idLocker)
        {
            try
            {
                return lockerData.getById(idLocker);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
