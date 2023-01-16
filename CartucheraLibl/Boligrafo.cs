using System.Text;

namespace CartucheraLibl
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor _color;
        private float _tinta;

        public Boligrafo(ConsoleColor color, float tinta)
        {
            this.color = color;
            _tinta = tinta;
        }

        public ConsoleColor color { get { return _color; } set { _color = value; } }
        public float UnidadesDeEscritura { get { return _tinta; } set { _tinta = value; } }

        public EscrituraWrapper Escribir(string texto)
        {
            UnidadesDeEscritura -= texto.Length * 0.3f;

            return new EscrituraWrapper(color, texto);  
        }

        public bool Recargar(int unidades)
        {
           UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Boligrafo {color},{UnidadesDeEscritura}");

            return sb.ToString();

        }

    }
}