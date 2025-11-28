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
        private static Dictionary<string, int> intentosFallidos = new Dictionary<string, int>();
        private static Dictionary<string, DateTime> bloqueados = new Dictionary<string, DateTime>();

        public List<UsuarioEntity> getAll()
        {
            try
            {
                return usuarioData.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public UsuarioEntity getAdmins(string nombre, string contraseña)
        {
            try
            {
                if (nombre == null || contraseña == null)
                {
                    throw new Exception("No se admiten campos nulos.");
                }
                return usuarioData.getAdmins(nombre, contraseña);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public UsuarioEntity Login(string nombreUsuario, string contraseña, string rol)
        {
            try
            {
                if (getAdmins(nombreUsuario, contraseña) != null)
                {
                    var usuario = usuarioData.getByNombreContraseña(nombreUsuario, contraseña, "administrador");
                    return usuario;
                }
                // 1. Verificar si está bloqueado
                if (bloqueados.ContainsKey(nombreUsuario))
                {
                    if (bloqueados[nombreUsuario] > DateTime.Now)
                    {
                        throw new Exception("Usuario bloqueado temporalmente. Intente más tarde.");
                    }
                    else
                    {
                        // Ya venció el bloqueo → quitarlo
                        bloqueados.Remove(nombreUsuario);
                        intentosFallidos[nombreUsuario] = 0;
                    }
                }

                // 2. Validar las credenciales
                

                if (usuarioData.getByNombreContraseña(nombreUsuario, contraseña, rol) == null)
                {
                    // Si no existe, aumentar intentos
                    if (!intentosFallidos.ContainsKey(nombreUsuario))
                        intentosFallidos[nombreUsuario] = 0;

                    intentosFallidos[nombreUsuario]++;

                    // Si supera 4 intentos → bloquear
                    if (intentosFallidos[nombreUsuario] >= 4)
                    {
                        bloqueados[nombreUsuario] = DateTime.Now.AddMinutes(1); // 1 min
                        throw new Exception("Usuario bloqueado por exceder los intentos.");
                    }

                    throw new Exception("Usuario, contraseña o rol incorrectos.");
                }

                // 3. Si inició sesión bien → resetear intentos
                if (intentosFallidos.ContainsKey(nombreUsuario))
                    intentosFallidos[nombreUsuario] = 0;


                return usuarioData.getByNombreContraseña(nombreUsuario, contraseña, rol);
                /*
                if (intentos >= 4)
                {
                    throw new Exception("Usuario, contraseña o rol incorrectos.");

                }
                if (usuarioData.getByNombreContraseña(nombreUsuario, contraseña, rol) == null)
                {
                    throw new Exception("Usuario, contraseña o rol incorrectos.");
                    intentos = intentos + 1;
                }
                var usuario = usuarioData.getByNombreContraseña(nombreUsuario, contraseña, rol);


                intentos = 0;
                return usuario;
                */
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
                if (nombreUsuario == null || contraseña == null || rol == null)
                {
                    throw new Exception("No se aceptan campos nulos.");
                }
                foreach (var user in getAll())
                {
                    if (user.Nombre_Usuario == nombreUsuario)
                    {
                        throw new Exception("Este nombre de usuario ya esta en uso.");
                    }
                }
                usuarioData.Registrar(nombreUsuario, contraseña, rol);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
