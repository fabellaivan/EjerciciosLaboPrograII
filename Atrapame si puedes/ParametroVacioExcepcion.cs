using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrapame_si_puedes
{
    public class ParametroVacioExcepcion : Exception
    {
        public ParametroVacioExcepcion(string mensaje):this(mensaje,null) 
        {

        }

        public ParametroVacioExcepcion(string mensaje, Exception innew):base(mensaje,innew)
        {

        }
    }
}
