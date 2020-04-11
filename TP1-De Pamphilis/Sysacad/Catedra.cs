using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class Catedra
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Personal jefe { get; set; }
        public Comision comision { get; set; }
        public Aviso aviso { get; set; }

    }
}
