using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class Comision
    {
        public int id { get; set; }
        public string turno { get; set; }
        public Horario horario { get; set; }
        public Aviso aviso { get; set; }
        public Examen examen { get; set; }
    

    }
}
