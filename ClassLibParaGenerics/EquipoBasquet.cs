using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public class EquipoBasquet : Equipos
    {
        public EquipoBasquet(string nombre, string tipoEquipo, DateTime fecha) : base(nombre, tipoEquipo, fecha)
        {
        }

    }
}
