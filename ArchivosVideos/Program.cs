namespace ArchivosVideos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Archivo.Escribir();

            Console.WriteLine(Archivo.Leer("LaboSW"));
          
        }
    }
}