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

    public string? ResidenteId { get; set; }
    public string? RepartidorId { get; set; }

    public virtual Residente? idResidenteNavigation { get; set; }
    public virtual Repartidore? idRepartidorNavigation { get; set; }
}
