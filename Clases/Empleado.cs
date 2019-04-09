using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public string Legajo { get; set; }
        public int Sueldo { get; set; }
        public Horario Horario { get; set; }
    }
}
