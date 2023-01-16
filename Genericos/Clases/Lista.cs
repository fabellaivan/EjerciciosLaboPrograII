using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Clases
{
    internal class Lista<T> 
        where T : Persona
        
        //where  T : struct = hace un tipo que se pase por valor. Un entero un string un char un double 
        //class tipo de valor por referencia de clase 
        // unmanaged no puede ser por referencia. Parecido a Struct 
        // new indica que el valor que puede ser T va a ser un valor Clase que tenga un constructor vacio = where T = new()
        //O de el tipo de clase que queramos como Persona
    {
       // T[] list;
        List<T> list;
       // Dictionary<U,V > dict;
        public Lista()
        {
            list = new List<T>();
           // dict = new Dictionary<U, V>();
        }
        public void Add(T elem)
        {
            list.Add(elem);
            
        }
        public void Remove(T elem)
        {
            list.Remove(elem);
        }

        public void Saludar(T persona)
        {
            persona.Saludar();
        }
        public void MetodoGenerico<W>(W value)
        {

        }
    }
}
