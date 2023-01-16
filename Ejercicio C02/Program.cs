using Formula1;

namespace Ejercicio_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia F1 = new Competencia(15, 5,Competencia.TipoDeCompetencia.F1);
            Competencia Motito = new Competencia(15, 5, Competencia.TipoDeCompetencia.MotoCross);
            Random rand = new Random();
            AutoF1[] autos = new AutoF1[5];

            AutoF1 BMW = new AutoF1(1523,"BMW",2500);
            VehiculoDeCarrera CHEVROLET = new AutoF1(1523, "CORSA",1500);       
            MotoCross motoTrueno = new MotoCross(1, "DUKE", 200);
            
         /*   for(int i=0;i<autos.Length;i++)
            {
                autos[i] = new AutoF1((short)i, rand.Next(1, 5).ToString());
                if (F1 + autos[i])
                {
                    Console.WriteLine($"El auto se agrego ok {autos[i].MostrarDatos()}");
                }
            }*/
            if (F1 + BMW)
            {
                Console.WriteLine("Se dio de alta correctamente");
                BMW.CantidadCombustible = 100;
                BMW.EnCompetencia = false;
                Console.WriteLine(BMW.MostrarDatos());
                Console.WriteLine("Fin de datos");
            }
            else
            {
                Console.WriteLine("No se puedo agregar el auto");
            }

            if(F1 + motoTrueno)
            {
                Console.WriteLine("ERror 1");
            }
            else
            {
               

            }
            

            /*   if(Motito + motoTrueno)
               {
                   Console.WriteLine("Se dio de alta correctamente");
                   motoTrueno.CantidadCombustible = 150;
                   Console.WriteLine(motoTrueno.MostrarDatos());
                   Console.WriteLine("Fin de datos");
               }


               if(F1  + CHEVROLET)
               {
                   Console.WriteLine("Se dio de alta correctamente");
                   Console.WriteLine(CHEVROLET.MostrarDatos());
                   Console.WriteLine("Fin de datos");
               }
               else
               {
                   Console.WriteLine("No se puedo agregar el auto");
               }*/

            Console.WriteLine(F1.MostrarDatos());
            Console.WriteLine("Fin de datos F1");
            Console.WriteLine(Motito.MostrarDatos());
            Console.WriteLine("Fin de datos Moto");

        }
    }
}