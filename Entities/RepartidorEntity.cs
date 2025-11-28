using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepartidorEntity
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set; }
        public string Num_Legajo { get; set; }
        public string Telefono { get; set; }
        public bool Credencial_Valida { get; set; }
    }
}
