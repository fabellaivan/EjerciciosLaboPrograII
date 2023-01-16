using Ejercicio_I02___Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02___Contabilidad
{
    internal class Contaduria
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Documento item in contabilidad._egresos)
            {
                Console.WriteLine(item._numero);
            }
            foreach (Documento item in contabilidad._ingresos)
            {
                Console.WriteLine(item._numero);
            }
        }
    }
}
