using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public class EquipoFutbol : Equipos
    {
        public EquipoFutbol(string nombre, string tipo,DateTime fecha) : base(nombre,tipo, fecha)
        {
        }
    }
}
