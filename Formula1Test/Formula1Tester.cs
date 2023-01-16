using Formula1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Formula1Test
{
    //Crear un test unitario que valide que la
    //lista de vehículos de la competencia esté instanciada al crear un nuevo objeto.
    [TestClass]
    public class Formula1Tester
    {
        [TestMethod]
        public void Formula1_SiListaVehiculosCompetenciaEstaVacia_EsTrue()
        {
            // Arrage
            bool expected = false;
            Competencia auxCompetencia = new Competencia(10, 10, Competencia.TipoDeCompetencia.MotoCross);
            if (auxCompetencia.Competidores.Count >= 0)
            {
                expected = true;
            }
            // Act

            Assert.IsTrue(expected);
        }


        //Realizar un test unitario que controle que la
        //excepción CompetenciaNoDisponible se lance al querer cargar un AutoF1 en una competencia del tipo MotoCross.

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Formula1_SiSeAgregaAutoF1ATipoCompetenciaMotoCross_DeberiaLanzarExcepcionCompetenciaNoDisponible()
        {
            
            Competencia Motito = new Competencia(15, 5, Competencia.TipoDeCompetencia.MotoCross);             
            VehiculoDeCarrera CHEVROLET = new AutoF1(1523, "CORSA", 1500);

            if(Motito + CHEVROLET)
            {

            }
           
        }

        //Realizar otro test que controle que la excepción CompetenciaNoDisponible 
        //NO se lance al querer cargar un objeto del tipo MotoCross en una competencia del tipo MotoCross.
        [TestMethod]
        public void Formula1_SiSeAgregaMotoCross1ATipoCompetenciaMotoCross_NoDeberiaLanzarExcepcionCompetenciaNoDisponible()
        {

            Competencia Motito = new Competencia(15, 5, Competencia.TipoDeCompetencia.MotoCross);
            MotoCross motoTrueno = new MotoCross(1, "DUKE", 200);
            try
            {
                if (Motito + motoTrueno)
                {
                    Assert.IsTrue(true);
                }
            }
            catch (CompetenciaNoDisponibleException)
            {
                Assert.IsTrue(false);
            }
        }
        //Comprobar que al cargar un nuevo vehículo en la competencia
        //este figure en la lista. Utilizar el operador + y el ==.
        [TestMethod]
        public void Formula1_AlCargarVehiculoEnCompetencia_DeberiaFigurarEnListaCompetidores()
        {
            Competencia Autos = new Competencia(15, 5, Competencia.TipoDeCompetencia.F1);
            VehiculoDeCarrera CHEVROLET = new AutoF1(1523, "CORSA", 1500);
     
            if (Autos + CHEVROLET)
            {              
               Assert.IsTrue(Autos == CHEVROLET);             
            }
            
        }
        //Comprobar que al quitar
        //un vehículo existente en la competencia este ya no figure en la lista. Utilizar el operador - y el !=.
        [TestMethod]
        public void Formula1_AlEliminarVehiculoDeCompetencia_NoDeberiaEstarEnLista()
        {
            Competencia Autos = new Competencia(15, 5, Competencia.TipoDeCompetencia.F1);
            VehiculoDeCarrera CHEVROLET = new AutoF1(1523, "CORSA", 1500);

            if (Autos + CHEVROLET)
            {
                if(Autos - CHEVROLET)
                {
                    if(Autos != CHEVROLET)
                    {
                        Assert.IsTrue(true);
                    }
                    else
                    {
                        Assert.IsTrue(false);
                    }             
               }
            }

        }
    }
}
