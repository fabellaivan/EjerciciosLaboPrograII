using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorEquipo
{
    public class Jugador
    {
        private int _dni;
        private string _name;
        private int _totalGoles;
        private int _totalJugados;
       

        private Jugador()
        {    
            _totalGoles = 0;
            _totalJugados = 0;
        }
        public Jugador(int dni, string name) : this()
        {
            setDni(dni);
            setNombre(name);
        }

        public Jugador(int dni, string name, int totalGoles, int totalPartidos) : this(dni,name)
        {
            setTotalGoles(totalGoles);
            setTotalJugados(totalPartidos);
        }

        public string Mostrar()
        {

            return $"Jugador {getName()} La cantidad de goles {getTotalGoles()} en {getTotalJugados()} partidos  El promedio {PromedioGoles()}";
                
        }

        public float PromedioGoles()
        {
            float promedio;
            promedio = (float)getTotalGoles() / getTotalJugados();
            return promedio;
        }
        #region getSet
        /* getter */
        public int getDni()
        {
            return _dni;
        }
        public String getName()
        {
            return _name;
        }
        public int getTotalGoles()
        {
            return (int)_totalGoles;
        }
        public int getTotalJugados()
        {
            return _totalJugados;
        }

        /*public float getPromedioGoles()
        {
            _promedioGoles = _totalGoles / _totalJugados;
            return _promedioGoles;
        }*/

        /* setters */
      
        public void setTotalGoles(int totalGoles)
        {
            _totalGoles = totalGoles;
        }
        public void setTotalJugados(int totalJugados)
        {
            _totalJugados = totalJugados;
        }
        public void setDni(int dni)
        {
            _dni=dni;
        }
        public void setNombre(String name)
        {
            _name = name;
        }
        #endregion GetSet

        #region SOBRECARGA
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.getDni == j2.getDni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        #endregion SOBRECARGA

    }
}
