using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pedidos
    {
        public Clientes Clientes { get; set; }       
        public Productos Productos { get; set; }

        public Clientes Clientes1
        {
            get => default(Clientes);
            set
            {
            }
        }

        public Productos Productos1
        {
            get => default(Productos);
            set
            {
            }
        }
    }
}
