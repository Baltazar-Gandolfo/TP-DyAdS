using DAO;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBusiness
    {
        private readonly UsuarioData usuarioData = new UsuarioData();

        public UsuarioEntity Login(string nombreUsuario, string contraseña, string rol)
        {
            var usuario = usuarioData.getByNombreContraseña(nombreUsuario, contraseña, rol);

            if (usuario == null)
                throw new Exception("Usuario, contraseña o rol incorrectos.");

            return usuario;
        }
    }
}
