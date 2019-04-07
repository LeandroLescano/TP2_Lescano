using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Depositos
    {
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
        public Sectores Sectores { get; set; }
        public Empleados Empleados { get; set; }
        public Clientes Clientes { get; set; }

        public Sectores Sectores1
        {
            get => default(Sectores);
            set
            {
            }
        }

        public Pedidos Pedidos
        {
            get => default(Pedidos);
            set
            {
            }
        }

        public Empleados Empleados1
        {
            get => default(Empleados);
            set
            {
            }
        }

        public Localidad Localidad1
        {
            get => default(Localidad);
            set
            {
            }
        }
    }
}
