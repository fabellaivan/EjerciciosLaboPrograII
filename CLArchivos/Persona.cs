using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CLArchivos
{
    public  class Persona
    {
        private string _nombre;
        protected long _dni;

        public Persona()
        {
           
           
        }
        public Persona(string nombre, int dni) : this()
        {
            Dni = dni;
            Nombre = nombre;

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
        public override string ToString()
        {
            return Nombre + "-" + Dni;
        }


    }
}
    