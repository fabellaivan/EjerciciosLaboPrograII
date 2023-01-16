using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class Equipo
    {
        private string _nombre;
        private List<Persona> _integrantes;
        public string nombre
        {
            get { return _nombre; }
        }
        public Equipo(string nombre)
        {
            _nombre = nombre;
            _integrantes = new List<Persona>();
        }

        public void Entrenar()
        {
            foreach (var item in _integrantes)
            {
                item.Saludar();
                item.Entrenar();
            }
        }
    }
}
