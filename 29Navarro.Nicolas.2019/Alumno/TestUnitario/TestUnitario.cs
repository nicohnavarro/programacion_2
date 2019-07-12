using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void TestMethodArchivosXML()
        {
            string stringAGuardar = "XmlPrueba";
            string stringLeido="";

            if (Archivos.Xml<string>.Guardar(stringAGuardar))
                stringLeido = Archivos.Xml<string>.Leer();

            Assert.AreEqual(stringAGuardar, stringLeido);
        }
    }
}
