using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        GenericVehiculoDeCarrera<VehiculoDeCarrera> _competidoresGenerico;

        private TipoDeCompetencia tipo;

        public enum TipoDeCompetencia
        {
            F1,
            MotoCross
        }
      

        public List<VehiculoDeCarrera> Competidores
        {
            get { return competidores; }
        }
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoDeCompetencia tipo) : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------COMPETENCIA------");
            sb.AppendLine($"Cantidad de vueltas: {_cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {_cantidadCompetidores}" );
            foreach (VehiculoDeCarrera vehiculo in competidores)
            {
                if(vehiculo.GetType()==typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                }
                else
                {
                    if(vehiculo.GetType()==typeof(MotoCross))
                    {
                        sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
                    }
                }
            

            }
            return sb.ToString();
        }
        public short CantidadCompetidores
        {
            get { return _cantidadCompetidores; }
            set { _cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return _cantidadVueltas; }
            set { _cantidadVueltas = value; }
        }
        public VehiculoDeCarrera this[int index]//indexador para acceder a un elemento de la lista 
        {
            get { return this.competidores[index]; }
        }
        
        public TipoDeCompetencia Tipo
        {
            get { return this.tipo; }
            set {tipo = value; }
        }

        #region SOBRECARGAS
        public static bool operator +(Competencia c, VehiculoDeCarrera vC)
        {
            //throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia");

            Random rdn = new Random();
            bool retorno = false;
            if (c.competidores.Count < c._cantidadCompetidores )
            {
               // try
              //  {
                    if (ComparaCompetenciaVehiculo(c, vC))
                    {
                        vC.EnCompetencia = true;
                        vC.VueltasRestantes = c._cantidadVueltas;
                        vC.CantidadCombustible = (short)rdn.Next(15, 100);
                        c.competidores.Add(vC);
                        retorno = true;
                    }
                    else
                    {
                        throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia");
                    }
              /*  }
                catch (CompetenciaNoDisponibleException ex)
                {

                    Console.WriteLine(ex.Message);
                    //Console.WriteLine(ex.ToString());
                }*/
            
            }
    
            return retorno;
        }
        public static bool ComparaCompetenciaVehiculo(Competencia c, VehiculoDeCarrera vC)
        {
            bool retorno = false;
           // try
           // {
                if ((c.Tipo == Competencia.TipoDeCompetencia.F1 && vC.GetType() == typeof(AutoF1))
                        || (c.Tipo == Competencia.TipoDeCompetencia.MotoCross && vC.GetType() == typeof(MotoCross)))
                {
                    retorno = true;
                }
               /* else
                {
                    throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia");
                }*/
           /* }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.ToString());
            }*/

            return retorno;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera vC)
        {
            bool retorno = false;
            if (c == vC)
            {
                c.competidores.Remove(vC);
                retorno = true;
            }
            return retorno;
        }
       
        public static bool operator ==(Competencia c, VehiculoDeCarrera vC)
        {
            bool retorno = false;
            
            if (ComparaCompetenciaVehiculo(c, vC))
            {
                if(c.competidores.Contains(vC))
                {
                    retorno = true;
                }
              /*  foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (item.Escuderia == vC.Escuderia && item.Numero == vC.Numero)
                    {
                        retorno = true;
                        break;
                    }
                }*/
            }
            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera vC)
        { 
            return !(c == vC);
        }
        #endregion SOBRECARGAS

    }
}
