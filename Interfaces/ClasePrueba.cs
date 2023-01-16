using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ClasePrueba : IPrueba<Courier>
    {
        //public static string Probar(IMensaje mensaje)
        //{
        //    return mensaje.EnviarMensaje();
        //}

        public Courier MostrarPersona<U>(U nombre) where U : AnimalVolador
        {
            return new Courier();
        }
    }
}
