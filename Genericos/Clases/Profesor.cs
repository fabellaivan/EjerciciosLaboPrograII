using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Clases
{
    internal class Profesor : Persona
    {
        public List<string> Materias { get; set; }
        public Profesor(string nombre, string apellido) : base(nombre, apellido)
        {
            Materias = new List<string>();
        }
    }
}
