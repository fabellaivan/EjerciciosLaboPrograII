using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GondolaLacteos
    {
        List<Lacteo> listLacteo;
        public GondolaLacteos()
        {
            ListLacteo = new List<Lacteo>();

        }

        public List<Lacteo> ListLacteo { get => ListLacteo; set => ListLacteo = value; }
        
    }
}
