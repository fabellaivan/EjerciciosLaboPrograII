using System.Drawing;
using Herencia;
namespace El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*VehiculoTerrestre camion0 = new Camion(8, 2, Colores.Blanco, 8, 5000);
            ((Camion)camion0).Mostrar((Camion)camion0);*/


            Camion camion = new Camion(9, 3, Colores.Negro, 9, 6000);
            camion.Mostrar(camion);

            VehiculoTerrestre camion1 = new Camion(8, 2, Colores.Blanco, 8, 5000);
            camion1.Mostrar((Camion)camion1);

            VehiculoTerrestre auto = new Automovil(4, 3,Colores.Blanco, 1500, 4);
            auto.Mostrar((Automovil)auto);

            Moto moto = new Moto(2, 0,Colores.Negro, 150);
            moto.Mostrar(moto);

            Escuderia autoConMarca = new Escuderia(4, 3, Colores.Blanco, 1500, 4,"Citroen","C4",123);
            autoConMarca.Mostrar((Escuderia)autoConMarca);

            /* Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas:" +
                 " {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", 
                 camion.cantidadRuedas, camion.cantidadPuertas, camion.color, camion.getSetCantidadMarchas,camion.getSetpesoCarga);*/


            /*Automovil auto = new Automovil(4, 5,  Colores.Blanco, 5, 3);
                Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: " +
                    "{1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantidadRuedas, autito.cantidadPuertas, autito.color, autito.cantidadMarchas, autito.cantidadPasajeros);
                Console.WriteLine("-----------");
                Moto moto = new Moto(2, 0, Colores.Rojo, 1000);
                Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantidadRuedas, motito.cantidadPuertas, motito.color, motito.cilindradas);
            */
        }
    }
}

