using DAO.Models;
using Entities;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LockerData
    {

        public List<LockerEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var lockers = context.Lockers
                        .Include(locks => locks.idRepartidorNavigation)
                        .Include(locks => locks.idResidenteNavigation)
                        .Select(locks => LockerMapper.Map(locks))
                        .ToList();
                    return lockers;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public LockerEntity getById(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var locker = context.Lockers
                        .Include(locks => locks.idRepartidorNavigation)
                        .Include(locks => locks.idResidenteNavigation)
                        .Where(locks => locks.LockerId == id)
                        .Select(locks => LockerMapper.Map(locks))
                        .FirstOrDefault();
                    return locker;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public List<LockerEntity> ObtenerPorResidente(string residenteId)
        {
            using (var context = new AppDbContext())
            {
                return context.Lockers
                    .Where(l => l.ResidenteId == residenteId)
                    .Select(l => LockerMapper.Map(l))
                    .ToList();
            }
        }


        public void ActualizarLoceker(LockerEntity lockerEntity)
        {
            using (var context = new AppDbContext())
            {
                var lockerDb = context.Lockers.FirstOrDefault(l => l.LockerId == lockerEntity.Id);

                if (lockerDb == null)
                    throw new Exception("Locker no encontrado");

                lockerDb.Ubicacion = lockerEntity.Ubicacion;
                lockerDb.Tamano = lockerEntity.Tamaño;
                lockerDb.Estado = lockerEntity.Estado;
                lockerDb.CodigoActual = lockerEntity.Codigo_Actual;
                lockerDb.FechaDeposito = lockerEntity.Fecha_Deposito;
                lockerDb.TrackingPaquete = lockerEntity.Tracking_Paquete;
                lockerDb.UltimaMantencion = lockerEntity.Ultima_Mantencion;

                lockerDb.ResidenteId = lockerEntity.ResidenteId;
                lockerDb.RepartidorId = lockerEntity.RepartidorId;

                context.SaveChanges();
            }
        }
        public void EliminarLocker(int idLocker)
        {
            using (var context = new AppDbContext())
            {
                var locker = context.Lockers.FirstOrDefault(l => l.LockerId == idLocker);

                if (locker == null)
                    throw new Exception("Locker no encontrado.");

                context.Lockers.Remove(locker);
                context.SaveChanges();
            }
        }
        public LockerEntity BuscarPorCodigo(string codigo)
        {
            using (var context = new AppDbContext())
            {
                var lockerDb = context.Lockers.FirstOrDefault(l => l.CodigoActual == codigo);

                return lockerDb != null ? LockerMapper.Map(lockerDb) : null;
            }
        }

    }
}
