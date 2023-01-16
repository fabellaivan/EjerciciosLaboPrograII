namespace ArchivosFILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchivosFile.Escribir(DateTime.Now.ToString("HH_mm_ss"));
            Console.WriteLine(ArchivosFile.Leer("LaboFile"));
           
        }
    }
}