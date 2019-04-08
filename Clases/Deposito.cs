using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Deposito
    {
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
        public Sector Sectores { get; set; }
        public Empleado Empleados { get; set; }
        public Cliente Clientes { get; set; }
    }
}
