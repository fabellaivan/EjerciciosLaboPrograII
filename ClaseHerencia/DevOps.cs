using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    public class DevOps : Programador
    {
       // private Programador _programador;

        public DevOps(string nombre,string apellido,int dni,int lineas) : base(nombre,apellido,dni,lineas)
        { }
        public override string Saludar()
        {
            return GetData();
        }

    }

}
