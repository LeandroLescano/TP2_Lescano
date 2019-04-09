using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public TipoProducto Tipo { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public Compartimiento Compartimiento
        {
            get => default(Compartimiento);
            set
            {
            }
        }
    }
}
