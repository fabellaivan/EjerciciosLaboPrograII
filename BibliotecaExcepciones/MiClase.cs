using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaExcepciones
{
    internal class MiClase
    {
        public static void Miclase()
        { 
            UnaExcepcion unaExcepcion = new UnaExcepcion();
            
            throw new UnaExcepcion();
        }
    }
}
