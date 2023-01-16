using ClassLibParaGenerics;
u
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Torneo_Testing
{
    [TestClass]
    public class TorenoTesting
    {
        [TestMethod]
        public void Toreno_SiElEquipoNoCorrespondeAToreno_DeberiaLanzarExcepcion()
        {
            Torneo<Equipos> torneoFutbol = new Torneo<Equipos>("Torneo Futbol","Futbol");
            EquipoBasquet e1 = new EquipoBasquet("e1","Basquest", DateTime.Parse("10/10/2222"));

            
            if (e1 + torneoFutbol)
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }
        
        }

        [TestMethod]
        public void Toreno_SiElEquipoCorrespondeAToreno_NoDeberiaLanzarExcepcion()
        {
            Torneo<Equipos> torneoFutbol = new Torneo<Equipos>("Torneo Futbol","Futbol");
            EquipoFutbol e1 = new EquipoFutbol("e1", "Futbol", DateTime.Parse("10/10/2222"));
     
           
            if (e1 + torneoFutbol)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
     
        }

        [TestMethod]
        public void Toreno_SiElEquipoEstaEnLista_DeberiaRetornarTrue()
        {
            Torneo<Equipos> torneoFutbol = new Torneo<Equipos>("Torneo Futbol","Futbol");
            EquipoFutbol e1 = new EquipoFutbol("e1","Futbol", DateTime.Parse("10/10/2222"));
            if (e1 + torneoFutbol)
            {
                if(e1==torneoFutbol)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);  
                }
            }
        
        }

        [TestMethod]
        public void Toreno_SiElEquipoNoEstaEnLista_DeberiaRetornarFalse()
        {
            Torneo<Equipos> torneoFutbol = new Torneo<Equipos>("Torneo Futbol","Futbol");
            EquipoFutbol e1 = new EquipoFutbol("e1", "Futbol", DateTime.Parse("10/10/2222"));
            EquipoFutbol e2 = new EquipoFutbol("e1", "Futbol", DateTime.Parse("10/10/2222"));
            if (e1 + torneoFutbol)
            {
                if (e2 == torneoFutbol)
                {
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }

        }
    }
}
