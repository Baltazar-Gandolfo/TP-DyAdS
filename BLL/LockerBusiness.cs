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

        public List<LockerEntity> ObtenerTodos()
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

        public LockerEntity BuscarPorCodigo(string codigo)
        {
            try
            {
                return lockerData.BuscarPorCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ActualizarLoceker(LockerEntity locker)
        {
            try
            {
                lockerData.ActualizarLoceker(locker);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public List<LockerEntity> ObtenerLockersDeResidente(string residenteId)
        {
            try
            {
                return lockerData.ObtenerPorResidente(residenteId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarLocker(int idLocker)
        {
            lockerData.EliminarLocker(idLocker);
        }
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
        

    }
}
