using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class Personal : Persona
    {
        public int id { get; set; }
        public DateTime fechaInicio { get; set; }
        public int antiguedad { get; set; }
    }
}
