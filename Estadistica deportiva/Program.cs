using JugadorEquipo;

namespace Estadistica_deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo HDI = new Equipo(6, "HDI");
            Jugador ivan = new Jugador(37557925, "Ivano",5,5);
            Jugador Aldana = new Jugador(37557925, "Aldana", 7, 3);
            Jugador Zazu = new Jugador(37557923, "Zazu", 15, 10);
            Jugador Peluza = new Jugador(37557225, "Peluza", 12, 0);
            Jugador Abu = new Jugador(37557945, "Abu", 40, 20);
           
            if(HDI+ivan)
            {
                Console.WriteLine(ivan.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }

            if (HDI + ivan)
            {
                Console.WriteLine(ivan.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }

            if (HDI + Aldana)
            {
                Console.WriteLine(Aldana.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }

            if (HDI + Zazu)
            {
                Console.WriteLine(Zazu.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }

            if (HDI + Peluza)
            {
                Console.WriteLine(Peluza.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }

            if (HDI + Abu)
            {
                Console.WriteLine(Abu.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }


        }
    }
}