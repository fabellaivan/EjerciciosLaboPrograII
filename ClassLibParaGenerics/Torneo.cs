using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public class Torneo<T> 
        where T : Equipos
       
    {
        private List<T> _equipos;
        private List<Deportista> _deportistas;  
        private string nombre;
        private string tipoTorneo;

        private Torneo()
        {
            _equipos = new List<T>();
            _deportistas = new List<Deportista>();
        }
        public Torneo(string nombre, string tipoTorneo) : this()
        {
            this.nombre = nombre;
            this.tipoTorneo = tipoTorneo;
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string TipoToreno
        { 
            get { return tipoTorneo; }
        }

        #region
        public static bool operator +(T equipo, Torneo<T> torneo)
        {
            bool retorno = false;
            try
            {
                if(ComparaTorneoEquipo(equipo, torneo))
                {
                    if (equipo != torneo)
                    {
                        torneo._equipos.Add(equipo);
                        retorno = true;
                    }
                    else
                    {
                        throw new Exception("El equipo ya esta en el torneo");
                    }
                }
                else
                {
                    throw new Exception("El equipo no corresponde al torneo");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
  
            return retorno;
        }
        private static bool ComparaTorneoEquipo(T equipo, Torneo<T> torneo)
        {
            bool retorno = false;
            try
            {
                if ((torneo.tipoTorneo == "Futbol" && equipo.tipo == "Futbol")
                        || (torneo.tipoTorneo == "Basquet" && equipo.tipo == "Basquet"))
                {
                    retorno = true;
                }
                else
                {
                    throw new Exception("El equipo no corresponde a la competencia");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.ToString());
            }

            return retorno;
        }

        public static bool operator ==(T equipo, Torneo<T> toreno)
        {
            bool retorno = false;
            try
            {
                if (toreno._equipos.Contains(equipo))
                {
                    retorno = true;
                }
                else
                {
                    throw new Exception("El equipo no esta en el torneo");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return retorno;
        }
        public static bool operator !=(T equipo, Torneo<T> toreno)
        {
            return !(equipo == toreno);
        }
        #endregion

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Torneo : {nombre}");

            foreach (T item in _equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();   
        }

        private string CalcularPartido(T equipoA, T equipoB)
        {
            Random r = new Random();
            return $" {equipoA.nombre} {r.Next(0, 5)}-{r.Next(0, 5)}  {equipoB.nombre}";
        }

        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                T equipoA;
                T equipoB;
                do 
                { 
                    equipoA = _equipos[r.Next(0, _equipos.Count)];
                    equipoB = _equipos[r.Next(0, _equipos.Count)];
                } while(equipoA == equipoB);              

                return CalcularPartido(equipoA, equipoB);

            }
          

        }
    }
}
