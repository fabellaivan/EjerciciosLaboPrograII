using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionJson
{
    public class Mascota
    {
        string nombre;
        string raza;
        int edad;
        bool peloCorto;
        bool esPerro;

        public Mascota(string nombre, string raza, int edad, bool peloCorto, bool esPerro)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Edad = edad;
            this.PeloCorto = peloCorto;
            this.EsPerro = esPerro;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool PeloCorto { get => peloCorto; set => peloCorto = value; }
        public bool EsPerro { get => esPerro; set => esPerro = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Raza: {Raza}");
            sb.AppendLine($"Edad: {Edad} ");
            sb.AppendLine($"Tiene pelo corto? {PeloCorto}");
            sb.AppendLine($"Es perro? {EsPerro} ");

            return sb.ToString();
        }
    }
}
