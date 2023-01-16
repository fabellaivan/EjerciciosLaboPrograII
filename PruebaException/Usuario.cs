using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaException
{
    public class Usuario
    {
        private string _nombre;
        private int edad;

        public Usuario(string nombre, int edad)
        {
            _nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"Los datos son : {_nombre} : {edad}";
        }
    }
}
