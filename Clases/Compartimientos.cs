using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Compartimientos
    {
        public Ubicacion Ubicacion { get; set; }

        public Productos Productos
        {
            get => default(Productos);
            set
            {
            }
        }
    }
}
