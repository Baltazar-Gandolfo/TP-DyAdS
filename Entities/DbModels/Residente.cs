using System;
using System.Collections.Generic;

namespace Entities.Models;
public partial class Residente
{
    public int ResidenteId { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Departamento { get; set; }

    public string Telefono { get; set; }

    public string Email { get; set; }

    public string PrefNotif { get; set; }

    public virtual ICollection<Locker> Lockers { get; set; } = new List<Locker>();
}
