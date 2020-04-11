using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class Materia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cuatrimestre { get; set; }
        public Catedra catedra { get; set; }
        public Aviso aviso { get; set; }
    }
}
