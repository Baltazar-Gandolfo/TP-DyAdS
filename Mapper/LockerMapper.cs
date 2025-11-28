using Entities;
using Entities.Models;

namespace Mapper
{
    public class LockerMapper
    {
        // EF → Entity
        public static LockerEntity Map(Locker locker)
        {
            return new LockerEntity()
            {
                Id = locker.LockerId,
                Ubicacion = locker.Ubicacion,
                Tamaño = locker.Tamano,
                Estado = locker.Estado,
                Codigo_Actual = locker.CodigoActual,
                Fecha_Deposito = locker.FechaDeposito,
                Tracking_Paquete = locker.TrackingPaquete,
                Ultima_Mantencion = locker.UltimaMantencion,

                ResidenteId = locker.ResidenteId,
                RepartidorId = locker.RepartidorId,

                Residente = locker.idResidenteNavigation != null
                    ? ResidenteMapper.Map(locker.idResidenteNavigation)
                    : null,

                Repartidor = locker.idRepartidorNavigation != null
                    ? RepartidorMapper.Map(locker.idRepartidorNavigation)
                    : null
            };
        }

        // Entity → EF
        public static Locker Map(LockerEntity lockerEntity)
        {
            return new Locker()
            {
                LockerId = lockerEntity.Id,
                Ubicacion = lockerEntity.Ubicacion,
                Tamano = lockerEntity.Tamaño,
                Estado = lockerEntity.Estado,
                CodigoActual = lockerEntity.Codigo_Actual,
                FechaDeposito = lockerEntity.Fecha_Deposito,
                TrackingPaquete = lockerEntity.Tracking_Paquete,
                UltimaMantencion = lockerEntity.Ultima_Mantencion,

                ResidenteId = lockerEntity.Residente?.Id,
                RepartidorId = lockerEntity.Repartidor?.Id
            };
        }
    }
}

