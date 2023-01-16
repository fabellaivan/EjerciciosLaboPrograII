using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Excepciones_Pruebas
{
    internal class Excepcion
    {
        static void Main(string[] args)
        {
             int x = 0;
             try
             {
                 int y = 100 / x;
             }
           /*  catch (ArithmeticException e)
             {
                 Console.WriteLine($"ArithmeticException Handler: {e}");
             }*/
             catch (Exception e)
             {
                // Console.WriteLine($"Generic Exception Handler aca pah: {e}");
                throw new Excepc("Dale play a que no da mensaje ");
               // throw new OverflowException("fallo");
            }
            Random random = new Random();

            int numAleatorio = random.Next(0, 5);

            int miNum = -1;
            int intentos = 0;

            Console.WriteLine("Ingrese un numero");

            do
            {
                intentos++;
                try
                {
                    miNum = int.Parse(Console.ReadLine());
                   
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("No ha introducido un numero ");
                  
                }
                catch(OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Numero muy grande ");
                    
                }
       
                if(miNum != -1)
                {
                    if (miNum > numAleatorio) Console.WriteLine("Mas abajo");
                    if (miNum < numAleatorio) Console.WriteLine("Mas arriba");
                }

            } while (numAleatorio != miNum);

            Console.WriteLine($" intentos {intentos}");
        }
    }
}
