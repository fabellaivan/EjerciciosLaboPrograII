using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_2
{
    internal class Ingreso_valor_mas_excepcion
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numAleatorio = random.Next(0, 100);

            int miNum;
            int intentos = 0;

            Console.WriteLine("Ingrese un numero");
            throw new NuevaExcepcion("Error");

            do
            {
                intentos++;
                miNum = int.Parse(Console.ReadLine());
                if (miNum > numAleatorio) Console.WriteLine("Numero inferior a lo permitido");
                if (miNum < numAleatorio) Console.WriteLine("Numero mayor a lo permitido");
            } while (numAleatorio != miNum);

            Console.WriteLine($" intentos {intentos}");

        }
    }
}
