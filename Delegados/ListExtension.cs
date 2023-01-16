using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate bool Delegadoriterio<T>(T element);

    public static  class ListExtension
    {
        public static List<T> Filtrar <T>(this List<T> lista,Delegadoriterio<T> criterioDeFiltrado)
        {

            List<T> retorno = new List<T>();

            foreach (T element in lista)
            {
                if(criterioDeFiltrado(element))
                {
                    retorno.Add(element);
                }
            }

            return retorno;
        }
    }
}
