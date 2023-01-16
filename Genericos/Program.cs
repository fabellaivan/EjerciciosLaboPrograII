using Genericos.Clases;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno aluno1 = new Alumno("Ivan","Fabella",123);
            Profesor profe = new Profesor("Maria","Garcia");
            Lista<Persona> lista = new Lista<Persona>();
           
            lista.Add(aluno1);
            lista.Add(profe);
            lista.Saludar(profe);
            lista.Saludar(aluno1);
        }
    }
}