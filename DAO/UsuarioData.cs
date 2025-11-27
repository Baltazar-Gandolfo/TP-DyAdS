using DAO.Models;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioData
    {
        public UsuarioEntity getByNombreContraseña(string nombre, string contraseña, string rol)
        {
            using (var context = new AppDbContext())
            {
                var usuario = context.Usuarios
                    .FirstOrDefault(t =>
                        t.NombreUsuario == nombre &&
                        t.Contraseña == contraseña &&
                        t.Rol == rol
                    );

                return usuario == null ? null : UsuarioMapper.Map(usuario);
            }
        }
    }
}
