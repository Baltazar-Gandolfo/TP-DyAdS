using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Repartidore
{
    public int RepartidorId { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Empresa { get; set; }

    public string LegajoNumero { get; set; }

    public string Telefono { get; set; }

    public bool CredencialValida { get; set; }

    public virtual ICollection<Locker> Lockers { get; set; } = new List<Locker>();
}
