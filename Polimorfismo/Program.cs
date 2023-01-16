using Polimorfismo.Clases;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* var preparadores = new List<PreparadorFisico>();
            var tecnicos = new List<Entrenador>();
            var jugadres = new List<Futbolista>();  */
            Entrenador entrenador = new Entrenador("Ivano");
            PreparadorFisico pFisico = new PreparadorFisico("Juan Perez");
            Futbolista futbolista = new Futbolista("Charly",EPosicion.Delantero);
            Futbolista futbolista2 = new Futbolista("Tito", EPosicion.Arquero);

            List<Persona> lista = new List<Persona>();
            
            lista.Add(futbolista2);
            //futbolista2.Saludar();
           /* lista.Add(entrenador);
            lista.Add(pFisico);
            lista.Add(futbolista);*/
            //lista.AddRange(jugadres);//agrega una lista a otra lista 
            Persona.EntrenarPlantel(lista);
            


            /*preparadores.Add(pFisico);
            tecnicos.Add(entrenador);
            jugadres.Add(futbolista);
            jugadres.Add(futbolista2);*/

           /* Persona.EntrenarPlantel(preparadores);
            Persona.EntrenarPlantel(tecnicos);
            Persona.EntrenarPlantel(jugadres);*/

            /*   foreach (var item in preparadores)
               {
                   item.Entrenar();
               }
               foreach (var item in tecnicos)
               {
                   item.Entrenar();
               }
               foreach (var item in jugadres)
               {
                   item.Entrenar();
               }*/
        }
    }
}