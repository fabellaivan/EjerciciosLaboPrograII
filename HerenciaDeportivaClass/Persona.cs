using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportivaClass
{
    public abstract class Persona
    {
        private string _nombre;
    
        protected long _dni;

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public Persona(string nombre, int dni) : this(nombre)
        {
 
            Dni = dni;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public long Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public virtual string MostrarDatos()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Nombre);
            sb.Append(Dni);           

            return sb.ToString();
        }
        public abstract string MostrarInternos();

    }
}
