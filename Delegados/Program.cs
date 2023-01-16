using System.Collections.Generic;

namespace Delegados
{
    internal class Program
    {
        private static List<int> list;
        static void Main(string[] args)
        {
           
            list = new List<int>()
            {
                3,46,6,9,70,45,33
            };

            MostrarNumeros();
            list = list.Filtrar(ObtenerCriterioFiltrado);
            MostrarNumeros();


        }
        public static void MostrarNumeros()
        {
            string numeros = "";

            foreach (int numero in list)
            {
                numeros += $"{numero} | ";

            }

            Console.WriteLine($"Num antes de filtrar: {numeros}");
        }
        public static bool ObtenerCriterioFiltrado(int numero)
        {
            return numero % 2 == 0;
        }

        public static void EjecutarEjemploNotificacio()
        {
            Console.WriteLine("Hello, World!");
            Receptor carpinchoReceptor = new Receptor("Carpincho receptor");
            Receptor ivanoReceptor = new Receptor("Ivano receptor");
            Receptor aldanaReceptor = new Receptor("Aldana Recepor");

            DelegadoDestinatario delegadoNew = new DelegadoDestinatario(carpinchoReceptor.RecibirNotificacion);
            Emisor.destinatarios.Add(delegadoNew);

            DelegadoDestinatario delegadoSinNew = ivanoReceptor.RecibirNotificacion;
            Emisor.destinatarios.Add(delegadoSinNew);


            Emisor.destinatarios.Add(aldanaReceptor.RecibirNotificacion);
            Emisor.destinatarios.Add(Notificar);
            Emisor.ProducirNotificacion();

        }

        public static void Notificar()
        {
            Console.WriteLine("Notificado");
        }

        public delegate void DelegadoDestinatario();


        public static class Emisor
        {
            public static List<DelegadoDestinatario> destinatarios = new List<DelegadoDestinatario>();

            public static void ProducirNotificacion()
            {

                //destinatarios.Sort(new Comparison<DelegadoDestinatario>(Comparar));
                destinatarios.Sort(Comparar);
                destinatarios.Where(Filtrar).ToList();

                Console.WriteLine("Tiempo");

                Thread.Sleep(2000);
                foreach(DelegadoDestinatario delegadoDestinatario in destinatarios)//destinatarios Lista de Receptor(es)
                {
                    delegadoDestinatario();//delegadoDestinatario == ivanoReceptor.RecibirNotificacion/ 
                    //o delegadoDestinatario.Invoke();
                }
            }

        }



        public static bool Filtrar(DelegadoDestinatario dDestinatario)
        {
            return dDestinatario.Method.Name.StartsWith('N') || dDestinatario.Method.Name.StartsWith('M');
        }

        public static int Comparar(DelegadoDestinatario el1,DelegadoDestinatario el2)
        {
            return string.Compare(el1.Method.Name, el2.Method.Name);
        }

        public class Receptor
        {
            string nombre;

            public Receptor(string nombre)
            {
                this.nombre = nombre;
            }

            public void RecibirNotificacion()
            {
                Console.WriteLine($"{nombre} notificado");
            }
        }
    }
}