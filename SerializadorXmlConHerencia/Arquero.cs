using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializadorXmlConHerencia
{
    public class Arquero : Personaje
    {
        bool tieneArmadura;
        public Arquero()
        {
        }

        public Arquero(string nombre,int nivel,bool armadura):base(nombre,nivel)
        {
            TieneArmadura = armadura;
        }

        public bool TieneArmadura { get => tieneArmadura; set => tieneArmadura = value; }
    }
}
