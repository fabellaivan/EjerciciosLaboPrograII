using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeFormas
{
    public class Rectangulo : Figura
    {
        private double _base;
        private double _altura;

        public Rectangulo(double @base, double altura)
        {
            _base = @base;
            _altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return Math.Round((2*_base+2*_altura)/2);
        }

        public override double CalcularSuperficie()
        {
            return Math.Round((_base*_altura),2);
        }
        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }
    }
}
