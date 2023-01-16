using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasSQL
{
    class Consola
    {

        static void Main(string[] args)
        {
            PersonaAccesoDatos.AddPersona(new Persona("Ivan","Fabella",1,213123.33));
            PersonaAccesoDatos.Change(new Persona("IVANO", "Fabella", 1, 33333.33));
            List<Persona> persona = PersonaAccesoDatos.Leer();
           
            foreach (Persona item in persona)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
