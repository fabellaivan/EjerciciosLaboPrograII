using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Carta : Papel, IMensaje
    {
        public string sello;

        public Carta(string tipi, int cantHojas) : base(tipi, cantHojas)
        {
        }

  
        public string AbrirCarta()
        {
            return "Abrir Carta";
        }

        public string EnviarMensaje()
        {
            return "Enviando mensaje carta";
        }
    }
}
