using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaLibro
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }
        public string this[int i]
        {
            get
            {
                if(i>=0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                   return  $"No se encontro la pgina";
                }
            }

            set
            {
                if(i > paginas.Count)
                {
                    paginas.Add(value);
                }
                else
                {
                    if(i>=0)
                    {
                        paginas.Insert(i, value);
                    }
                }
            }
        }

    }
}
