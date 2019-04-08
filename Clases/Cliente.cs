using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Persona
    {
        public string Codigo { get; set; }
        public Pasillo Pasillo { get; set; }
    }
}
