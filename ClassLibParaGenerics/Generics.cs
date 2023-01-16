using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public class Deportistas<T > 
        where T : Deportista
    { 
        List<T> _jugadores;
        
        List<string> _listaDeportistas;

        private Deportistas()
        {
            _jugadores = new List<T>();
               
            _listaDeportistas = new List<string>();
         
        }

        public void SumarEquipoAJugador(T deportista,string nuevoEquipo)
        {
            if(deportista is not null && nuevoEquipo is not null)
            {
                foreach(T jugador in _jugadores)//excepcion
                {
                    if(jugador == deportista)
                    {
                        
                        deportista.AgrgarClubAJugador(nuevoEquipo);
                        
                    }
                }
            }
        }

        public Deportistas(string numobreEquipo):this()
        {
            _listaDeportistas.Add(numobreEquipo);
        }

        public void Add(T elem)
        {
            _jugadores.Add(elem);

        }

        public void MostrarDatos()
        {
            foreach (var item in _jugadores)
            {
               item.GetData();
            }
        }

        public bool EstaEnLista(T human)
        {
            bool retorno = false;

            foreach(T item in _jugadores)
            {
                if(item == human)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

    }
}
