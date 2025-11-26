using Entities;
using Entities.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ResidenteMapper
    {
        public static ResidenteEntity Map(Residente idResidenteNavigation)
        {
            return new ResidenteEntity()
            {
                Id = idResidenteNavigation.ResidenteId,
                Nombre = idResidenteNavigation.Nombre,
                Apellido = idResidenteNavigation.Apellido,
                Departamento = idResidenteNavigation.Departamento,
                Telefono = idResidenteNavigation.Telefono,
                Pref_Notificacion = idResidenteNavigation.PrefNotif,
                Email = idResidenteNavigation.Email

            };
        }
    }
}
