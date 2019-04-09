using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Compartimiento
    {
        public Cliente Propietario { get; set; }
        public TipoProducto TipoProd { get; set; }
        public Stock Cantidad { get; set; }
    }
}
