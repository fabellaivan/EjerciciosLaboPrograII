using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public abstract class Humano
    {
        private string _nombre;
        private string _apellido;
        protected int _dni;

        public Humano(string nombre, string apellido, int dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
        }

        public virtual string GetData()
        {
            var sb = new StringBuilder();

            sb.Append(_nombre);
            sb.Append(" ");
            sb.Append(_apellido);
            sb.Append(" ");
            sb.Append(_dni);

            return sb.ToString();
        }
        public abstract string Saludar();

    }
}
