using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_2
{   public class NuevaExcepcion : Exception
    {
        public NuevaExcepcion(string mensaje):base(mensaje)
        {

        }

    }
}
