using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class LockerMapper
    {
        public static LockerEntity Map(Locker locker)
        {
            return new LockerEntity()
            {
                Id = locker.LockerId,
                Ubicacion = locker.Ubicacion,
                Tamaño = locker.Tamano,
                Estado = locker.Estado,
                Codigo_Actual = locker.CodigoActual,
                Fecha_Deposito = Convert.ToDateTime(locker.FechaDeposito),
                Tracking_Paquete = locker.TrackingPaquete,
                Ultima_Mantencion = Convert.ToDateTime(locker.UltimaMantencion),
                Residente = ResidenteMapper.Map(locker.idResidenteNavigation),
                Repartidor = RepartidorMapper.Map(locker.idRepartidorNavigation)

            };
        }

        public static Locker Map(LockerEntity lockerEntity)
        {
            return new Locker()
            {
                LockerId = lockerEntity.Id,
                Ubicacion = lockerEntity.Ubicacion,
                Tamano = lockerEntity.Tamaño,
                Estado = lockerEntity.Estado,
                CodigoActual = lockerEntity.Codigo_Actual,
                FechaDeposito = Convert.ToDateTime(lockerEntity.Fecha_Deposito),
                TrackingPaquete = lockerEntity.Tracking_Paquete,
                UltimaMantencion = Convert.ToDateTime(lockerEntity.Ultima_Mantencion),
                ResidenteId = Convert.ToString(lockerEntity.Residente.Id),
                RepartidorId = Convert.ToString(lockerEntity.Repartidor.Id)

           };
        }
    }
}
