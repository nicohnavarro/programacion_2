using System;
using Carrera;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carrera;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Asserge
            Competencia competenciaPrueba = new Competencia(2, 2, Competencia.TipoCompetencia.F1);
            //Act
            //Assert
            Assert.IsNotNull(competenciaPrueba.CantidadCompetidores);
        }

        [TestMethod]
        [ExpectedException (typeof(CompetenciaNoDisponibleException))]
        public void TestMethod2()
        {
            //Asserge
            Competencia competenciaPrueba = new Competencia(2, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto1 = new AutoF1(2, "Ferrari");
            //Act
            bool prueba=competenciaPrueba + auto1;
            //Assert
        }
        
    }
}
