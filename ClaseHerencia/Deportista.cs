using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    public class Deportista : Humano
    {
        private ElDeportista _eDeportista;
        public Deportista(string nombre, string apellido, int dni, ElDeportista eDeportista) : base(nombre, apellido, dni)
        {
            _eDeportista = eDeportista;
        }


        public int GetDni()
        {
            return _dni;
        }

        public override string GetData()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Tipo deportista " + _eDeportista.ToString());

            sb.AppendLine(base.GetData());

            return sb.ToString();
        }

        public override string Saludar()
        {
            return GetData();
        }
    }
}
