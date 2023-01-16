using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class Entrenador : Persona
    {
        public Entrenador(string nombre):base(nombre)
        { }
        public override string Entrenar()
        {
            var sb = new StringBuilder();
            sb.Append(ToString());
            sb.Append(" Soy dete");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
    }
}
