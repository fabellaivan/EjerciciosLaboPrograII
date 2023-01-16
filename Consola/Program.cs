using Interfaces;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paloma paloma = new Paloma("Paloma", "Palomon");
            Courier courirer = new Courier("Ivan", "Fabella","333");
            Carta carta = new Carta("tipo", 10);
            Email mail = new Email("Origen","mail");
            Cuervo cuervo = new Cuervo("Cuervo");

            List<IMensaje> mensaje = new List<IMensaje>();
            
            mensaje.Add(mail);
            mensaje.Add(carta);
            mensaje.Add(paloma);
            mensaje.Add(courirer);

            Console.WriteLine(((IEncriptado)cuervo).EnviarMensaje());

            Console.WriteLine(cuervo.EnviarMensaje());

            ClasePrueba prueba = new ClasePrueba();

           // Courier courier2 = prueba.MostrarPersona<Paloma>(paloma);

            

            foreach(IMensaje item in mensaje)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

        }
    }
}