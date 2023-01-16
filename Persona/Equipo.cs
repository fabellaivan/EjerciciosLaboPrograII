using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorEquipo
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> listaJugadores;
        private string _nombre;

        private Equipo()
        {
            listaJugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            _cantidadDeJugadores = cantidadDeJugadores;
            _nombre = nombre;
        }

        #region getSet
        /* getter */
        public short getCantidadDeJugadores
        {
            get { return _cantidadDeJugadores; }
        }
        public string getNombre
        {
            get { return _nombre; }
        }
        /* setters */
        public void setCantidadDeJugadores(short cantidad)
        {
            _cantidadDeJugadores = cantidad;
        }

        public void setNombre(string nombre)
        {
            _nombre = nombre;
        }

        #endregion getSet

        #region SOBRECARGA

        public static bool operator +(Equipo e, Jugador j )
        {
            bool retorno = true;
            if(e.listaJugadores.Count < e.getCantidadDeJugadores )
            {
                foreach(Jugador item in e.listaJugadores)
                {
                    if(item.getDni() == j.getDni())
                    {
                        retorno = false;
                    }
                }
                e.listaJugadores.Add(j);                
            }
            else
            {
                retorno = false;
            }

            return retorno;
            
        }

        #endregion SOBRECARGA
    }
}
