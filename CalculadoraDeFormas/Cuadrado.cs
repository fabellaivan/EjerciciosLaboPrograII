using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeFormas
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double baseAltura) : base(baseAltura, baseAltura)
        {
        }
        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
