using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string sexo { get; set; }
        public string password { get; set; }
        public DateTime fechanacimiento { get; set; }
        public string correo { get; set; }
    }
}
