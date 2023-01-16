using GenericsChancho;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Galpon<string> galponPalabras = new Galpon<string>("a", 2, 2);

            Galpon<Lacteo> lacteos = new Galpon<Lacteo>("a", 2, 2);

            Galpon<Avion> hangar = new Galpon<Avion>("a", 2, 2);

            hangar.Primerelemento();

            lacteos.Primerelemento();

            galponPalabras.GuardarObjeto("Un Objeto");

           
            
            
            
            
            
            
            
            
            
            
            
            
            /* Inventario<Avion, Lacteo, string> inventario
                = new Inventario<Avion, Lacteo, string>();

            Inventario<int, string, string> inventario2
                = new Inventario<int, string, string>();*/
        }  
    }
}