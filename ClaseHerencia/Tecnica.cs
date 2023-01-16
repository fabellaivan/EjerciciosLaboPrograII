using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    public class Tecnica : Deportista
    {
        public Tecnica(string nombre, string apellido, int dni, ElDeportista eDeportista) : base(nombre, apellido, dni, eDeportista)
        {
        }

        public override string GetData()
        {
            var sb = new StringBuilder();
            sb.AppendLine("================");

            sb.Append(base.GetData());

            sb.AppendLine("================");

            return sb.ToString();
        }
    }
}
