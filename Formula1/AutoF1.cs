using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short _caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        
        public AutoF1(short numero, string escuderia,short caballosDeFuerza) : this(numero, escuderia)
        {
            _caballosDeFuerza = caballosDeFuerza;
        }
        public short CaballosDeFuerza
        {
            get { return _caballosDeFuerza; }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza = {CaballosDeFuerza}");
            return sb.ToString();
        }

        #region SOBRECARGA

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
           if((a1 is not null) && (a2 is not null))
           {
                if((a1.Numero == a2.Numero) && (a1.Escuderia == a2.Escuderia))
                {
                    retorno = true;
                }
           }
           return retorno;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        #endregion SOBRECARGA
    }
}
