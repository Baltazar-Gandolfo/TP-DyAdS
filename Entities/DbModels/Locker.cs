using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Locker
{
    public int LockerId { get; set; }

    public string Ubicacion { get; set; } = null!;

    public string Tamano { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string CodigoActual { get; set; } = null!;

    public DateTime FechaDeposito { get; set; }

    public string TrackingPaquete { get; set; } = null!;

    public DateTime UltimaMantencion { get; set; }

    public string ResidenteId { get; set; } = null!;

    public string RepartidorId { get; set; } = null!;

    public virtual Repartidore idRepartidorNavigation { get; set; } = null!;

    public virtual Residente idResidenteNavigation { get; set; } = null!;
}
