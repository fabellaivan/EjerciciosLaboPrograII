using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportivaClass
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
        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            if (e.listaJugadores.Count < e.getCantidadDeJugadores)
            {
                foreach (Jugador item in e.listaJugadores)
                {
                    if (item.Dni != j.Dni)
                    {
                        e.listaJugadores.Add(j);
                        retorno = true;
                        break;
                    }
                }
                
            }
   

            return retorno;

        }
    }
}
