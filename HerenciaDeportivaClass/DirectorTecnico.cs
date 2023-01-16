using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportivaClass
{
    public class DirectorTecnico : Persona
    {
        private DateTime _fechaNacimiento;
        public DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public DateTime fechaNacimientoG
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public override string MostrarDatos()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Fecha nacimiento " + fechaNacimientoG.ToString("d"));           
            return sb.ToString();
        }

        public override string MostrarInternos()
        {
            return "salamin";
        }

        public static bool operator ==(DirectorTecnico t1, DirectorTecnico t2)
        {
            bool retorno = false;
            if(t1 is not null && t2 is not null)
            {
                if(t1.Nombre == t2.Nombre && t1.Dni == t2.Dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(DirectorTecnico t1, DirectorTecnico t2)
        {
            return !(t1 == t2);
        }
    }
}
