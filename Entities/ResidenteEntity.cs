using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ResidenteEntity
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pref_Notificacion { get; set; }
    }
}
