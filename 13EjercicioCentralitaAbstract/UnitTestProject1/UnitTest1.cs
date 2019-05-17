using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodA()
        {
            //Arrange
            Centralita centralitaPrueba1=new Centralita();
            //Act
            //Assert
            Assert.AreNotEqual(centralitaPrueba1.Llamadas,null);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethodB()
        {
            //Arrange
            Centralita centralitaPrueba1 = new Centralita();
            Local llamadaPrueba1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local llamadaPrueba2 = new Local("Bernal", 10, "Rosario", 3.65f);
            //Act
            centralitaPrueba1 += llamadaPrueba1;
            centralitaPrueba1 += llamadaPrueba2;
            //Assert manejado por el ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethodC()
        {
            //Arrange
            Centralita centralitaPrueba1 = new Centralita();
            Provincial llamada1 = new Provincial("Rosario",Provincial.Franja.Franja_3, 30,"Bariloche");
            Provincial llamada2 = new Provincial("Rosario", Provincial.Franja.Franja_2, 10, "Bariloche");

            //Act
            centralitaPrueba1 += llamada1;
            centralitaPrueba1 += llamada2;

            //Assert manejado por el ExpectedException
        }

        [TestMethod]
        public void TestMethodD()
        {
            //Arrange
            Centralita centralitaPrueba1 = new Centralita();
            Local llamadaLocal1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local llamadaLocal2 = new Local("Bernal", 10, "Rosario", 3.65f);
            Provincial llamadaProvincial3 = new Provincial("Bernal", Provincial.Franja.Franja_3, 30, "Rosario");
            Provincial llamadaProvincial4 = new Provincial("Bernal", Provincial.Franja.Franja_2, 10, "Rosario");

            //Act

            //Assert

            //Llamada1
            Assert.AreEqual(llamadaLocal1, llamadaLocal2);
            Assert.AreNotEqual(llamadaLocal1, llamadaProvincial3);
            Assert.AreNotEqual(llamadaLocal1, llamadaProvincial4);
            //Llamada2
            Assert.AreEqual(llamadaLocal2, llamadaLocal1);
            Assert.AreNotEqual(llamadaLocal2, llamadaProvincial3);
            Assert.AreNotEqual(llamadaLocal2, llamadaProvincial4);
        }

        [TestMethod]
        public void TestMethod_LlamadaLocal_CalcularCosto()
        {
            //Arrange
            Local llamadaPrueba = new Local("Bernal", 30, "Rosario", 3.50f);
            float costoReal = 3.50f * 30;
            float costoPrueba;

            //Act
            costoPrueba = llamadaPrueba.CostoLlamada;
            //Assert
            Assert.AreEqual(costoReal, costoPrueba);
        }

        [TestMethod]
        public void TestMethod_LlamadaLocal_Equals()
        {
            //Arrange
            Local llamadaPrueba1 = new Local("Bernal", 30, "Rosario", 3.50f);
            //Act
            //Assert
            //Assert.AreEqual(llamadaPrueba1.Equals(llamadaPrueba1), typeof(Local));
        }

        [TestMethod]
        public void TestMethod_LlamadaLocal_Builder()
        {
            string origen = "54546";
            string destino = "5656";
            int duracion = -30;
            float costo = 3.65f;
            Local llamadaPrueba1 = new Local("Bernal", 30, "Rosario", 3.65f);
            Local llamadaPrueba2 = new Local(origen, duracion, destino, costo);
            Local llamadaPrueba3 = new Local(llamadaPrueba1,costo);

            
            Assert.AreNotSame(llamadaPrueba1, llamadaPrueba2);
            Assert.AreEqual(llamadaPrueba1, llamadaPrueba3);

        }
    }
}
