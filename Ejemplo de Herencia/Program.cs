namespace Ejemplo_de_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Juan Pablo", "11222233", 9999);
        }            
        public class Persona
        {
        private string nombre;
        private string dni;

            public Persona(string nombre, string dni)
            {
            this.nombre = nombre;
            this.dni = dni;
            }
        }

        public class Estudiante : Persona
        {
            private int legajo;

            public Estudiante(string nombreEstudiante, string dni, int legajo) : base(nombreEstudiante, dni)
            {
                this.legajo = legajo;
            }
        }
    }
    
}