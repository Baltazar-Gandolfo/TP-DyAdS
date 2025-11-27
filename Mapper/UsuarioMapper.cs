using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class UsuarioMapper
    {
        public static UsuarioEntity Map(Usuario usuario)
        {
            return new UsuarioEntity()
            {
                Id = usuario.UsuarioId,
                Nombre_Usuario = usuario.NombreUsuario,
                Contraseña = usuario.Contraseña,
                Rol = usuario.Rol

            };
        }

        public static Usuario Map(UsuarioEntity usuarioEntity)
        {
            return new Usuario()
            {
                UsuarioId = Convert.ToString(usuarioEntity.Id),
                NombreUsuario = usuarioEntity.Nombre_Usuario,
                Contraseña = usuarioEntity.Contraseña,
                Rol = usuarioEntity.Rol

            };
        }
    }
}
