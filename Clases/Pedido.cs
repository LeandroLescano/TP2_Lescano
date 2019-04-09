using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
