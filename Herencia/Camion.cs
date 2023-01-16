using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Camion : VehiculoTerrestre
    {
        private short _cantidadDeMarchas;
        private int           _pesoCarga;
        private Colores            color;
        public Camion(short cantidadRuedas,
            short cantidadPuertas, Colores color, short cantidadMarchas,int pesoCarga) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            getSetCantidadMarchas = cantidadMarchas;
            getSetpesoCarga       =       pesoCarga;
            this.color            =           color;
        }
        public short getSetCantidadMarchas
        {
            get { return _cantidadDeMarchas; }
            set { _cantidadDeMarchas = value; }
        }
        public int getSetpesoCarga
        {
            get { return _pesoCarga; }
            set { _pesoCarga = value; }
        }

     /*   public void Mostrar(Camion camion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Camion Cantidad de ruedas: {camion.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {camion.cantidadPuertas}");
            sb.AppendLine($"Color: {camion.color}");
            sb.AppendLine($"Marchas: {camion.getSetCantidadMarchas} ");
            sb.AppendLine($"Peso total de carga: {camion.getSetpesoCarga} ");
            sb.AppendLine("---------------------");
            Console.Write(sb);
        }*/


    }
}
