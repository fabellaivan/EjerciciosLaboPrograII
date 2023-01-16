using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    public sealed class Programador : Humano
    {
        private int _lineasPorHora;

        public Programador(string nombre, string apellido, int dni, int lineas) : base(nombre, apellido, dni)
        {
            _lineasPorHora = lineas;
        }

        public override string Saludar()
        {
            return GetData();
        }
    }
}
