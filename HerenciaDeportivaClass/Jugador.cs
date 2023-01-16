using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportivaClass
{
    public class Jugador : Persona
    {
        private int _partidosJugados;
        private int _totalGoles;
    
        public int PartidosJugados
        {
            get { return _partidosJugados; }
            set { _partidosJugados = value; }
        }
        public int TotalGoles
        {
            get { return _totalGoles; }
            set { _totalGoles = value; }
        }
        public float PromedioGoles
        {
            get { return ((float)TotalGoles / PartidosJugados); }
        }
        
        public Jugador(string nombre, int dni):base(nombre,dni)
        {}
        public Jugador(string nombre,int dni,int totalGoles, int totalPartidos):this(nombre,dni)
        {
           TotalGoles=totalGoles;
           PartidosJugados=totalPartidos;
        }
        public override string MostrarInternos()
        {
            return "Jugador";
        }

        public override string MostrarDatos()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Total Goles " + TotalGoles.ToString());
            sb.AppendLine("Total Jugados " + PartidosJugados.ToString());
            sb.AppendLine("Promedio de gol " + PromedioGoles.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1 is not null && j2 is not null)
            {
                if (j1.Nombre == j2.Nombre && j1.Dni == j2.Dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
