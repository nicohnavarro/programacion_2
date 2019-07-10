using System;
using ComiqueriaLogic.Comun;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestComiqueria
    {
        [TestMethod]
        public void TestMetodoDeExtensionComiqueria()
        {
            //Arrange
            double precio=100;
            string precioStr;
            string resultado="$ 100,00";
            //Act
            precioStr = precio.FormatearPrecio();
            //Assert
            Assert.AreEqual(resultado, precioStr);
        }
    }
}
