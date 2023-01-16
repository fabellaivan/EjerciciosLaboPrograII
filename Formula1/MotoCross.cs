using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short _cilindrada;

        private MotoCross(short numero, string escuderia) : base(numero, escuderia) { }

        public MotoCross(short numero, string escuderia,short cilindrada):this(numero,escuderia)
        {
            _cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get { return _cilindrada; }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindros = {Cilindrada}");
            return sb.ToString();
        }

        #region SOBRECARGA

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;
            if ((m1 is not null) && (m2 is not null))
            {
                if ((m1.Numero == m2.Numero) && (m1.Escuderia == m2.Escuderia) 
                    && (m1.Cilindrada == m2.Cilindrada))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        #endregion SOBRECARGA
    }
}
