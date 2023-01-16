using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartucheraLibl
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.color { get { return ConsoleColor.Gray; } set { } }
        float IAcciones.UnidadesDeEscritura { get { return tamanioMina; } set { tamanioMina = value; } }

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {

            ((IAcciones)this).UnidadesDeEscritura -= texto.Length * 0.1f;

            return new EscrituraWrapper(((IAcciones)this).color, texto);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Boligrafo {((IAcciones)this).color},{((IAcciones)this).UnidadesDeEscritura}");

            return sb.ToString();

        }       

    }
}
