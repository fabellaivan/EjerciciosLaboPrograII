using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Moto : VehiculoTerrestre
    {
        private short _cilindradas;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindradas) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this._cilindradas = cilindradas;
        }
        public short getCilindradas
        {
            get { return _cilindradas; }
        }
    }
}
