using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pasillo
    {
        public Cliente Propietario { get; set; }
        public Lado LadoDerecho { get; set; }
        public Lado LadoIzquierdo { get; set; }
    }
}
