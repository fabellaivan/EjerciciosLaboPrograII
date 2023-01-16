using HerenciaDeportivaClass;
namespace HerenciaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo HDI = new Equipo(6, "HDI");
            Jugador Aldana = new Jugador("Aldana", 37557925,  7, 3);
            Jugador Zazu = new Jugador("Zazu", 37557923,  15, 10);
            Jugador Peluza = new Jugador("Peluza", 37557225,  12, 0);
            Jugador Abu = new Jugador("Abu", 37557945,  40, 20);
           
            var fecha = new DateTime(2008, 5, 1);   
            
            DirectorTecnico dete = new DirectorTecnico("Roberte", fecha);
            Console.WriteLine(dete.MostrarInternos());
            Console.WriteLine(dete.MostrarDatos());

            Console.WriteLine(Aldana.MostrarInternos());
            Console.WriteLine(Aldana.MostrarDatos());
           
            Console.WriteLine(Abu.MostrarDatos());
            Console.WriteLine(Peluza.MostrarDatos());
           
           
        }
    }
}