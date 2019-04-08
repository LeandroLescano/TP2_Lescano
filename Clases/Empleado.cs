using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado : Persona
    {
        public int Sueldo { get; set; }
        public Horario Horario { get; set; }
    }
}
