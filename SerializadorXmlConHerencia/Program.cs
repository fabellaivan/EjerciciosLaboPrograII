namespace SerializadorXmlConHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaPersonajeLista;
            rutaPersonajeLista = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaPersonajeLista += @"\Archivos_Serializador\SerializadorUnitarioLista personajes.xml";
            Arquero arquero = new Arquero("Arquerito",20,true);
            Espadachin espadachin = new Espadachin("Espadachin", 10, false);

            ClaseSerializadora<Arquero>.Escribir(arquero, "Arquerito");
            ClaseSerializadora<Espadachin>.Escribir(espadachin, "Espadachin");

            List<Personaje> personajes = new List<Personaje>();
            personajes.Add(arquero);
            personajes.Add(espadachin);

            ClaseSerializadora<List<Personaje>>.Escribir(personajes, "Lista personajes");

            Arquero arquerito = ClaseSerializadora<Arquero>.Leer("Arq");
            Espadachin espadero =  ClaseSerializadora<Espadachin>.Leer("Espada");
            List<Personaje> lista = ClaseSerializadora<List<Personaje>>.Leer("List");
            
            Console.WriteLine("Arquerito\n"+arquerito);
            Console.WriteLine("Espadero\n" + espadero);

            Console.WriteLine(" \nToda la lista");
            foreach(var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        

        }
    }
}