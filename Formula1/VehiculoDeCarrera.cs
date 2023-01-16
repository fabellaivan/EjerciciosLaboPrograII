using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public abstract class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return escuderia; }
            set { escuderia = value; }
        }

        public short Numero
        {
            get { return numero; }
            set { numero = value; }

        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }
        public virtual string MostrarDatos()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Vueltas restantes {vueltasRestantes}");
            sb.AppendLine($"Numero: {numero}");
            if(EnCompetencia==true)
            {
                sb.AppendLine($"El competidor esta en carrera");
            }
            else
            {
                sb.AppendLine($"El competidor ha finalizado la carrera");
            }
            return sb.ToString();
        }
    }
}
