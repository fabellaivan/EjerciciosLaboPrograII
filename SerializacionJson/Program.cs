namespace SerializacionJson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("Enano", "Gato", 4, true, false);

            List<Mascota> listaMascotas = new List<Mascota>()
            {
                new Mascota("Enano", "Gato", 4, true, false),
                new Mascota("Luna", "Gato", 4, true, false),
                new Mascota("Abu", "Gato", 3, true, false),
                new Mascota("Peluza", "Gato", 3, true, false),

            };

            ClaseSerializadora<Mascota>.EscribirJSON(mascota, "Mascota");
            ClaseSerializadora<List<Mascota>>.EscribirJSON(listaMascotas, "lista");

            Mascota auxMascota = ClaseSerializadora<Mascota>.Leer("Mascota");
            List<Mascota> auxListMascota = ClaseSerializadora<List<Mascota>>.Leer("lista");

            Console.WriteLine($"Mascota sola:\n{auxMascota.ToString()}\n ");

            Console.WriteLine("Lista de mascotas\n");
            foreach(var item in auxListMascota)
            {
                Console.WriteLine(item.ToString());
            }
               
            

        }
    }
}