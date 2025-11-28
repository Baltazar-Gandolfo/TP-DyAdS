using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Repartidore
{
    public string RepartidorId { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Empresa { get; set; } = null!;

    public string LegajoNumero { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public bool CredencialValida { get; set; }

    public virtual ICollection<Locker> Lockers { get; set; } = new List<Locker>();

}
