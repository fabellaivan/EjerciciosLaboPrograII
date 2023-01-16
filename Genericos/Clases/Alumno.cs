using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Clases
{
    internal class Alumno : Persona
    {
        public int Legajo;

        public int _Legajo { get; set; }

        public Alumno(string nombre, string apellido, int legajo) : base(nombre, apellido)
        {
            Legajo = legajo;    
        }
    }
}
