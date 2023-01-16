using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeFormas
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(radio, 2);
        }
        public override string Dibujar()
        {
            return "Dibujando Círculo";
        }
    }
}
