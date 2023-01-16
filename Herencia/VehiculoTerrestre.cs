using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class VehiculoTerrestre
    {
        protected short  cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores         color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores colores)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = colores;
        }


        public void Mostrar(Camion camion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Camion");
            sb.AppendLine($"Cantidad de ruedas: {camion.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {camion.cantidadPuertas}");
            sb.AppendLine($"Color: {camion.color}");
            sb.AppendLine($"Marchas: {camion.getSetCantidadMarchas} ");
            sb.AppendLine($"Peso total de carga: {camion.getSetpesoCarga} ");
            sb.AppendLine("---------------------");
            Console.Write(sb);
            //Console.WriteLine(sb.ToString());

        }
        public void Mostrar(Automovil auto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto");
            sb.AppendLine($"Cantidad de ruedas: {auto.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {auto.cantidadPuertas}");
            sb.AppendLine($"Color: {auto.color}");
            sb.AppendLine($"Marchas: {auto.getSetCantidadMarchas} ");
            sb.AppendLine($"Cantidad pasajeros: {auto.getSetCantidadPasajeros} ");
            sb.AppendLine("---------------------");
            Console.Write(sb);
        }

        public void Mostrar(Moto moto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Moto");
            sb.AppendLine($"Cantidad de ruedas: {moto.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {moto.cantidadPuertas}");
            sb.AppendLine($"Color: {moto.color}");
            sb.AppendLine($"Cilindradas: {moto.getCilindradas} ");
            sb.AppendLine("---------------------");
            Console.Write(sb);
        }
        public void Mostrar(Escuderia autoEscudeto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto con escudeto");
            sb.AppendLine($"Cantidad de ruedas: {autoEscudeto.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {autoEscudeto.cantidadPuertas}");
            sb.AppendLine($"Color: {autoEscudeto.color}");
            sb.AppendLine($"Cantidad pasajeros: {autoEscudeto.getSetCantidadPasajeros} ");
            sb.AppendLine($"Escuderia: {autoEscudeto.getSetEscuderia}");
            sb.AppendLine($"Año Modelo: {autoEscudeto.getSetAnioModelo}");
            sb.AppendLine($"Modelo {autoEscudeto.getSetModelo}");
            sb.AppendLine("---------------------");
            Console.Write(sb);
        }
    }
}
