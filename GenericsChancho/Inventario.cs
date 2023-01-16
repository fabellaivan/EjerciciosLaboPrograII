using BibliotecaGenerics;
using System;

namespace GenericsChancho
{
    public class Inventario<U>
    where U : MedioDeTransporte
    {
        
        List<U> listMedioTransporte;

        public Inventario(List<U> listMedioTransporte)
        {
            this.listMedioTransporte = listMedioTransporte;
        }

        public void SumarCantidadCombustible()
        {
            foreach (U u in listMedioTransporte)
            {
                u.nombre = "ivan";
                u.MostrarNombre();
            }

        }
    } 
}