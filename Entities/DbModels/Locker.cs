using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Locker
{
    public int LockerId { get; set; }

    public string Ubicacion { get; set; }

    public string Tamano { get; set; }

    public string Estado { get; set; }

    public string CodigoActual { get; set; }

    public DateTime FechaDeposito { get; set; }

    public string TrackingPaquete { get; set; }

    public DateTime UltimaMantencion { get; set; }

    public int ResidenteId { get; set; }

    public int RepartidorId { get; set; }

    public virtual Repartidore idRepartidorNavigation { get; set; }

    public virtual Residente idResidenteNavigation { get; set; }
}
