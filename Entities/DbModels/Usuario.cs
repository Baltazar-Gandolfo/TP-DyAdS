using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Usuario
{
    public string UsuarioId { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Rol { get; set; } = null!;
}
