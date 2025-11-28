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
        public static ResidenteEntity Map(Residente residente)
        {
            return new ResidenteEntity()
            {
                Id = residente.ResidenteId,
                Nombre = residente.Nombre,
                Apellido = residente.Apellido,
                Departamento = residente.Departamento,
                Telefono = residente.Telefono,
                Email = residente.Email,
                Pref_Notificacion = residente.PrefNotif
            };
        }

        public static Residente Map(ResidenteEntity entity)
        {
            return new Residente()
            {
                ResidenteId = entity.Id.ToString(),
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Departamento = entity.Departamento,
                Telefono = entity.Telefono,
                Email = entity.Email,
                PrefNotif = entity.Pref_Notificacion
            };
        }
    }
}
