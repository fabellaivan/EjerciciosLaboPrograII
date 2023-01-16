using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Contabilidad
{
    public abstract class Documento
    {
        public int _numero;
        public Documento(int numero)
        {
            _numero = numero;
        }
    }
}
