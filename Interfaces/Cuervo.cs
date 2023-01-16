using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuervo : AnimalVolador, IMensaje,IEncriptado
    {
        public Cuervo(string nombre) : base(nombre)
        {
        }

        public string EnviarMensaje()
        {
            return "Enviando Mensaje Cuervo";
        }
        string IEncriptado.EnviarMensaje()
        {
            return "Enviando Mensjae Encriptado";
        }
    }
}
