namespace ConsolaSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<Persona> persona = PersonaAccesoDatos.Leer();
                foreach (Persona item in persona)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}