using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Papel
    {
        protected string _tipo;
        protected int cantHojas;

        protected Papel(string tipi, int cantHojas)
        {
            this._tipo = tipi;
            this.cantHojas = cantHojas;
        }
    }
}
