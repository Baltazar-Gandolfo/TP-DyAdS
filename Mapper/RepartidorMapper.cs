using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class RepartidorMapper
    {
        public static RepartidorEntity Map(Repartidore idRepartidorNavigation)
        {
            return new RepartidorEntity()
            {
                Id = idRepartidorNavigation.RepartidorId,
                Nombre = idRepartidorNavigation.Nombre,
                Apellido = idRepartidorNavigation.Apellido,
                Credencial_Valida = Convert.ToBoolean(idRepartidorNavigation.CredencialValida),
                Telefono = idRepartidorNavigation.Telefono,
                Empresa = idRepartidorNavigation.Empresa,
                Num_Legajo = idRepartidorNavigation.LegajoNumero,
            
            };
        }
    }
}
