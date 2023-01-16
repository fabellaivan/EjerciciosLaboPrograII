using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibParaGenerics
{
    public abstract class Equipos
    {
        public string nombre;
        public string tipo;
        private DateTime fechaCreacion;

        public Equipos(string nombre,string tipoEquipo, DateTime fecha)
        {
            this.nombre = nombre;
            this.tipo = tipoEquipo;
            this.fechaCreacion = fecha;
        }
        public string Ficha()
        {
            return $"Equipo {nombre} fundado el {fechaCreacion.ToString("dd/MM/yyyy")}";
        }
        public string Tipo
        {
            get { return tipo; }
        }

        public static bool operator ==(Equipos equipo, Equipos equipo2)
        {
            bool retorno = false;
            if((equipo.nombre == equipo2.nombre) && 
                (equipo.fechaCreacion == equipo2.fechaCreacion))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Equipos equipo, Equipos equipo2)
        {
            return !(equipo == equipo2);

        }
    }
}
