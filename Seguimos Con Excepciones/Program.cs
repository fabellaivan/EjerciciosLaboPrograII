namespace Seguimos_Con_Excepciones
{
    internal class Program
    {
        /* static void Main(string[] args)
         {
             string[] palabras = new string[4] { "  ivan", "Aldana", null, "sarasa" };

             try
             {
                 string resultad = DevolverPalabra(palabras, "sarasa");
                 Console.WriteLine(GuardarEnBaseDats(resultad));
             }
             catch(Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("Error controlado");
             }
             Console.WriteLine("Finish him");


         }*/
        static void Main(string[] args)
        {
            string[] palabras = new string[4] { "  ivan", "Aldana", null, "sarasa" };
  
            string resultad = DevolverPalabra(palabras, "sarasa");

            Console.WriteLine(GuardarEnBaseDats(resultad));

            Console.WriteLine("Finish him");


        }

        private static string DevolverPalabra(string[] datos, string palabraBuscar)
        {
            string palabra;
            for (int i = 0; i < datos.Length; i++)
            {
                try
                {
                    if (datos[i].Trim().ToLower() == palabraBuscar.Trim().ToLower())
                    {
                        return palabra = datos[i].Trim().ToLower();
                        break;
                    }
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine($"Fallo por linea null {i}");
                    
                   // throw;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"fallo al comprar {i}");
                }
            }
            return "no esta";
        }

        static string GuardarEnBaseDats(string palabra)
        {
            return $"Se Guardo en base datoss {palabra}";
        }
    }
}