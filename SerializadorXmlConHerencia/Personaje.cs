using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializadorXmlConHerencia
{
    [XmlInclude(typeof(Arquero))]
    [XmlInclude(typeof(Espadachin))]
    public class Personaje
    {

        private string nombre;
        private int nivel;

        public Personaje() { }

        public Personaje(string nombre, int nivel)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
        }

        public string Nombre { get => nombre; set => nombre = value; } 

        public int Nivel { get => nivel; set => nivel = value; }

        public override string ToString()
        {
            return $"Nombre : {nombre} - Nivel {nivel}";
        }
    }
}
