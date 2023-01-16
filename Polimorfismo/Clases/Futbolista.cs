using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class Futbolista : Persona
    {
        private EPosicion _posicion;

        public EPosicion EPosicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }
        public Futbolista(string nombre, EPosicion posicion) : base(nombre)
        {
            _posicion = posicion;
        }

        public override string Saludar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            sb.AppendLine("Como estas ");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        public override string Entrenar()
        {
            var sb = new StringBuilder();
            sb.Append(ToString());
            sb.Append(" Correndo");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        /*public override string Saludar()
        {
            return ToString();
        }*/
    }
}
