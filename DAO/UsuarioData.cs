using DAO.Models;
using Entities.Models;
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

        public void Registrar(string nombreUsuario, string contraseña, string rol)
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    string nuevoId  = Guid.NewGuid().ToString();

                    Usuario nuevo = new Usuario()
                    {
                        UsuarioId = nuevoId,
                        NombreUsuario = nombreUsuario,
                        Contraseña = contraseña,
                        Rol = rol.ToLower()
                    };

                    context.Usuarios.Add(nuevo);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar usuario: " + ex.Message);
            }
        }

        
    }
}
