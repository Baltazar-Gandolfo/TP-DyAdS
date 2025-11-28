using DAO.Models;
using Entities;
using Entities.Models;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioData
    {
        public List<UsuarioEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var usuarios = context.Usuarios.ToList();
                    List<UsuarioEntity> usuariosEntity = new List<UsuarioEntity>();
                    foreach (var user in usuarios)
                    {
                        usuariosEntity.Add(UsuarioMapper.Map(user));
                    }
                    return usuariosEntity;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public UsuarioEntity getByNombreContraseña(string nombre, string contraseña, string rol)
        {
            try
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
            catch (Exception ex)
            {
                throw;
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
            catch (FormatException ex)
            {
                throw new Exception("Error al registrar usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        
    }
}
