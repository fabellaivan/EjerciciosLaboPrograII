using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXml
{
    public class Consola
    {
        static void Main(string[] args)
        {
            string rutaPersonajeUnico;
            rutaPersonajeUnico = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaPersonajeUnico += @"\Archivos_Serializador\SerializadorUnitario.xml";

            string rutaPersonajeLista;
            rutaPersonajeLista = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaPersonajeLista += @"\Archivos_Serializador\SerializadorLista.xml";


            Personaje personaje = new Personaje("ivan", 1555);
            Personaje personaje1 = new Personaje("aldi", 155);
            Personaje personaje2 = new Personaje("abu", 564);
            Personaje personaje3 = new Personaje("Peluza", 2546);

            List<Personaje> lista = new List<Personaje>();
            lista.Add(personaje1);
            lista.Add(personaje2);
            lista.Add(personaje3);  
            lista.Add(personaje);


            ClaseSerializadora.Escribir(personaje);
            ClaseSerializadora.Escribir(lista);


            Personaje pj = ClaseSerializadora.Leer(rutaPersonajeUnico);
            Console.WriteLine("Unitario:");
            Console.WriteLine(pj.ToString());

            List<Personaje> personajes = ClaseSerializadora.LeerLista(rutaPersonajeLista);
            Console.WriteLine("\n\nLista"); 
            foreach(var item in personajes)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
