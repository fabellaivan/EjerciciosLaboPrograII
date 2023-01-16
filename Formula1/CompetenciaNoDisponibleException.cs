using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return nombreClase; }
        }
        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }

        public CompetenciaNoDisponibleException(string mensaje): base(mensaje,null)
        {
            
        }
        public CompetenciaNoDisponibleException(string mensaje, Exception innerException,
            string clase, string metodo) : this( mensaje)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion en el metodo {NombreMetodo} de la class {nombreClase}");

            return sb.ToString();
        }


    }
}
