using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Automovil : VehiculoTerrestre
    {
        private short _cantidadDeMarchas;
        private int   _cantidadPasajeros;
        public  Colores            color;

        public Automovil(short cantidadRuedas,
            short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadDePasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            getSetCantidadMarchas   =     cantidadMarchas;
            getSetCantidadPasajeros = cantidadDePasajeros;
            this.color              =               color;
        }

        internal short getSetCantidadMarchas
        {
            get { return _cantidadDeMarchas; }
            set { _cantidadDeMarchas = value; }
        }
        internal int getSetCantidadPasajeros
        {
            get { return _cantidadPasajeros; }
            set { _cantidadPasajeros = value; }
        }
    }
}
