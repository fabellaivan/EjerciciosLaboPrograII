using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _dni;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, string dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
        }
        public string Correr()
        {
            return "Corriendo";
        }
    }
}
