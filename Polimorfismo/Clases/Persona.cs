using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public abstract class Persona//Cuando una clase es abstracta no se puede instanciar (no se puede hacer un new Persona)
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Persona(string nombre)
        {
            _nombre = nombre;
        }

        public abstract string Entrenar();

        public override string ToString()
        {
            return "Nombre ->"+_nombre;
        }
        public virtual string Saludar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hola");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        /*  public static void EntrenarPlantel(List<PreparadorFisico> pF)
          {
              foreach (var item in pF)
              {
                  item.Entrenar();
              }
          }
          public static void EntrenarPlantel(List<Entrenador> e)
          {
              foreach (var item in e)
              {
                  item.Entrenar();
              }
          }
          public static void EntrenarPlantel(List<Futbolista> f)
          {
              foreach (var item in f)
              {
                  item.Entrenar();
              }
          }*/
        public static void EntrenarPlantel(List<Persona> ob)
        {
            foreach (var item in ob)
            {
               item.Saludar();
               item.Entrenar();
            }
        }
    }
}
