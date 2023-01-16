using ParaLibro;
namespace Libro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParaLibro.Libro libro = new ParaLibro.Libro();
            libro[0] = "Ivano Fabella";
            libro[1] = "Enano Zazu";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Sarasa";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}