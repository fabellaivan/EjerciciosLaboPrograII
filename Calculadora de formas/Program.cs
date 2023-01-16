using CalculadoraDeFormas;
using System.Text;

namespace Calculadora_de_formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(10);
            Rectangulo rectangulo = new Rectangulo(7, 5);
            Circulo circulo = new Circulo(6);
            //figuras.Add(new Circulo(2));

            List<Figura> listaFiguras = new List<Figura>();
            listaFiguras.Add(cuadrado);
            listaFiguras.Add(circulo);
            listaFiguras.Add(rectangulo);

            StringBuilder sb = new StringBuilder();
            int i=1;    
            foreach (Figura figura in listaFiguras)
            {
                Console.WriteLine($"Figura{i}");
                Console.WriteLine($"Tipo{figura.GetType()}");
                Console.WriteLine($"Area ={figura.CalcularSuperficie()}");
                Console.WriteLine($"Permietro ={figura.CalcularPerimetro()}");
                i++;
            }
        }
    }
}