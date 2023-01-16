using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_Pruebas
{
    public class Excepc : Exception
    {
        public Excepc(string mensaje):base(mensaje)
        {

        }
    }
}
