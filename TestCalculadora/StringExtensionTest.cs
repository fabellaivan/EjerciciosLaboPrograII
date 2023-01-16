using ContadorString;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]

    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrage
            int expected = 0;
            string text = "tryplkjhg dfghj";

            // Act
           // int actual = stringclas.ContadorVocales(text);
            int actual = text.ContadorVocales();//esto por la forma de la firma del metodo static contadorVocales 

            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void ContarVocales_CuandoTieneVocales_DeberiaRetornarCuantas()
        {
            // Arrage
            bool expected = false;
            int vocalesEsperads = 3;
            string text = "trop epwl msd!a";
            // Act
            if(text.ContadorVocales() == vocalesEsperads)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void ContadorCaracteres_CuandoNoTieneCaracteresIndicados_DeberiaRetornarCero()
        {
            // Arrage
            bool expected = false;
            int caracteresEsperads = 0;
            string text = "trop epwl msd!a";
            char caracter = ';';
            // Act
            if (text.ContadorCaracteres(caracter) == caracteresEsperads)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void ContadorCaracteres_CuandoTieneDosCaracteresIndicados_DeberiaRetornarDos()
        {
            // Arrage
            bool expected = false;
            int caracteresEsperads = 2;
            string text = "trop ;epwl; msd!a";
            char caracter = ';';
            // Act
            if (text.ContadorCaracteres(caracter) == caracteresEsperads)
            {
                expected = true;
            }
            Assert.IsTrue(expected);
        }

    }
}
