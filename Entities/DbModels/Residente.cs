using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Residente
{
    public string ResidenteId { get; set; } = null!;
    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PrefNotif { get; set; } = null!;

    public virtual ICollection<Locker> Lockers { get; set; } = new List<Locker>();

}
