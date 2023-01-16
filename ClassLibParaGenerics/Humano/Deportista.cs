using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public class Deportista : Humano
    {
        private ElDeportista _eDeportista;
        private string _equipo;
        private List<string> _listaEquiposJugados;

        public Deportista(string nombre, string apellido, int dni, ElDeportista eDeportista) : base(nombre, apellido, dni)
        {
            _listaEquiposJugados = new List<string>();
            _eDeportista = eDeportista;
         
        }

        public int LenghLista
        {
            get { return _listaEquiposJugados.Count; }
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

        public bool AgrgarClubAJugador(string nombreClub)
        {
            bool retorno = false;
            if (nombreClub is not null)
            {
                if (LenghLista > 0)
                {
                    _equipo = nombreClub;
                }
                else
                {
                    _listaEquiposJugados.Add(_equipo);
                    _equipo = nombreClub;
                }
            }
            return retorno;

        }
    }
}
