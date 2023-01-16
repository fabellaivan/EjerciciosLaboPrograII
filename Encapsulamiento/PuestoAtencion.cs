using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulamiento
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get { return ++numeroActual; }
        }
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puestoIn)
        {
            puesto = puestoIn;
        }
        public bool Atender(Cliente cl)
        {
            if(cl is not null)
            {
                Console.WriteLine("Sleep for 2 seconds.");
                Thread.Sleep(2000);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
