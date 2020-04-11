using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class InscripcionExamen
    {
        public Alumno alumno { get; set; }
        public Examen examen { get; set; }
        public DateTime fecha { get; set; }
        public float resultado { get; set; }

    }
}
