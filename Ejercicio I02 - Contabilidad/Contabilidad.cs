using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Contabilidad
{
    public class Contabilidad<T, U>
        where T : Documento
        where U : Documento, new()//Obligo (con new)a que el obj U tenga un
                                  //constructor publico y sin parametros.
    {
        public List<T> _egresos;
        public List<U> _ingresos;

        public Contabilidad()
        {
            _egresos = new List<T>();
            _ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c._egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c._ingresos.Add(ingreso);
            return c;
        }
    }
}
