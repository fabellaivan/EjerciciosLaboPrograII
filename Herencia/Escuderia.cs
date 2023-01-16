using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Escuderia : Automovil
    {
        private string _escuderia;
        private string    _modelo;
        private short  anioModelo;
        
        public Escuderia(short cantidadRuedas,
            short cantidadPuertas, Colores color, 
            short cantidadMarchas, int cantidadDePasajeros,
            string escuderia, string modelo, short aModelo) 
            : base(cantidadRuedas,cantidadPuertas, color,cantidadMarchas,cantidadDePasajeros)
        {
            getSetAnioModelo = aModelo;
            getSetModelo = modelo;
            getSetEscuderia = escuderia;
        }
        
        internal string getSetEscuderia
        {
            get { return _escuderia; }
            set { _escuderia = value; }
        }
        internal string getSetModelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        internal short getSetAnioModelo
        {
            get { return anioModelo; }
            set { anioModelo = value; }
        }
    }
}
