using ClassLibParaGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipos> torneoBasquet = new Torneo<Equipos>("Torneo Basquet","Basquet");
            Torneo<Equipos> torneoFutbol = new Torneo<Equipos>("Torneo Futbol","Futbol");
            EquipoBasquet e1 = new EquipoBasquet("e1", "Basquet", DateTime.Parse("10/10/2222"));
            EquipoBasquet e2 = new EquipoBasquet("e2", "Basquet", DateTime.Parse("10/10/2222"));
            EquipoBasquet e3 = new EquipoBasquet("e3", "Basquet", DateTime.Parse("10/10/2222"));
            EquipoFutbol ef1 = new EquipoFutbol("Racing", "Futbol", DateTime.Now);
            EquipoFutbol ef2 = new EquipoFutbol("Dock Sud", "Futbol", DateTime.Now);
            EquipoFutbol ef3 = new EquipoFutbol("Lanus", "Futbol", DateTime.Now);
           

            Deportistas<Deportista> deportistas = new Deportistas<Deportista>("Deportistas Zona sur");
            Humano jugadorBasquet = new Deportista("Aldana", "Medina", 36555555, ElDeportista.Basquetbolista);
            Humano jugadorFutbol = new Deportista("Ivan", "Fabella", 37223232, ElDeportista.Futbolista);

            deportistas.Add((Deportista)jugadorFutbol);

            deportistas.SumarEquipoAJugador((Deportista)jugadorFutbol, ef1.nombre);

            deportistas.MostrarDatos();


            if (e1 + torneoBasquet)
            {
                 
            }
            if (e2 + torneoBasquet)
            {

            }
            _ = ef1 + torneoFutbol;
            _ = ef2 + torneoFutbol;
            _ = ef3 + torneoFutbol;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);


        }
    }
}
