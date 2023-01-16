using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // NO SE PUEDE INSTANCIAR CLASE ABSTRACTA!!!
            //var humano = new Humano("juan", "Perezx", 1221); 
            Deportista basquet = new Deportista("Juan", "Perez", 123, ElDeportista.Automovilista);

            Programador programador = new Programador("Maria", "Barrios", 321, 232);

            var tecnico = new Tecnica("Pedro", "Guitierrez", 3434, ElDeportista.Futbolista);

            Console.WriteLine(basquet.GetData());

            Console.WriteLine(programador.GetData());

            Console.WriteLine(tecnico.GetData());
        }
    }
}
