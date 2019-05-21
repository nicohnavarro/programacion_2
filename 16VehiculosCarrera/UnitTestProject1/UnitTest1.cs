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
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void TestMethod2()
        {
            //Asserge
            Competencia competenciaPrueba = new Competencia(2, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto1 = new AutoF1(2, "Ferrari");
            //Act
            bool prueba = competenciaPrueba + auto1;
            //Assert
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Asserge
            Competencia competenciaPrueba = new Competencia(3, 3, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCrossPrueba = new MotoCross(1, "Ducatti");
            //AutoF1 auto = new AutoF1(1, "Ferrari");
            bool prueba=false;
            //Act
            try
            {
                //prueba = competenciaPrueba + auto;
                prueba = competenciaPrueba + motoCrossPrueba;
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Assert.Fail(ex.Message);
            }
            //Assert
            Assert.AreEqual(prueba,true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Asserge
            Competencia competenciaPrueba = new Competencia(3, 3, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCrossPrueba = new MotoCross(1, "Ducatti",3);
            bool prueba=false;
            bool resultado=false;
            //Act
            prueba = competenciaPrueba + motoCrossPrueba;
            foreach(MotoCross motoAux in competenciaPrueba.VehiculosDeCompetencia)
            {
                
                if(motoAux==motoCrossPrueba)
                {
                    resultado = true;
                    break;
                }
            }
            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Asserge
            Competencia competenciaPrueba = new Competencia(3, 3, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCrossPrueba = new MotoCross(1, "Ducatti", 3);
            MotoCross moto2 = new MotoCross(2, "Corven", 2);
            bool prueba1 = false;
            bool prueba2 = false;
            bool resultado = false;
            int cantidad;
            //Act
            prueba1 =competenciaPrueba+motoCrossPrueba;
            prueba1 = competenciaPrueba + moto2;
            prueba2 = competenciaPrueba - motoCrossPrueba;
            cantidad = competenciaPrueba.VehiculosDeCompetencia.Count;
            foreach(MotoCross motoAux in competenciaPrueba.VehiculosDeCompetencia)
            {
                if (motoAux != motoCrossPrueba)
                    resultado = true;
            }
            //Assert
            Assert.AreEqual(1, cantidad);
            Assert.IsTrue(resultado);
        }
    }
}
