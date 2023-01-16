using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class PreparadorFisico : Persona
    {
        public PreparadorFisico(string nombre):base(nombre)
        {}
        public override string Entrenar()
        {
            var sb = new StringBuilder();
            sb.Append(ToString());
            sb.Append(" Preparador Fisico");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
    }
}
