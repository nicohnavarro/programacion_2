using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class TestVotacion
    {
        [TestMethod]
        [ExpectedException (typeof(ErrorArchivoException))]
        public void TestExceptionErrorArchivoI()
        {
            //Arrange
            SerializarXML<Votacion> Xml = new SerializarXML<Votacion>();
            Votacion votacionPrueba=null;
            //Act
            Xml.Guardar("c\\", votacionPrueba);
            //Assert Manejado por la Excepcion
        }

        [TestMethod]
        public void TestSenadoresII()
        {
            //Arrange
            Dictionary<string, Votacion.EVoto> diccionarioPrueba=new Dictionary<string, Votacion.EVoto>();
            Votacion votacionPrueba;
            int contador = 0;
            //Act
            diccionarioPrueba.Add("Senador1", Votacion.EVoto.Abstencion);
            diccionarioPrueba.Add("Senador2", Votacion.EVoto.Negativo);
            diccionarioPrueba.Add("Senador3", Votacion.EVoto.Afirmativo);
            diccionarioPrueba.Add("Senador4", Votacion.EVoto.Afirmativo);
            votacionPrueba = new Votacion("Ley 25.125", diccionarioPrueba);
            votacionPrueba.EventoVotoEfectuado += MetodoContador;

            votacionPrueba.Simular();

            void MetodoContador(string senador, Votacion.EVoto voto)
            {
                contador++;
            }

            //Assert
            Assert.AreEqual(4, contador);
        }

    }
}
