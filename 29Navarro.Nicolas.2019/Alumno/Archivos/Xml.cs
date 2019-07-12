using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public static class Xml<T>
    {
        private static XmlTextWriter writer;
        private static XmlSerializer ser;
        private static XmlTextReader reader;

        static Xml()
        {
            writer = null;
            reader = null;
        }

        public static bool Guardar(T datos)
        {
            bool retorno = false;
            string path = string.Format("{0}\\Bitacora.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            try
            {
                writer = new XmlTextWriter(path, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                retorno = true;
            }

            catch (ErrorArchivoException exc)
            {
                throw new ErrorArchivoException("Error en Archivo Xml", exc);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return retorno;
        }

        public static T Leer()
        {
            T retorno;
            string path = string.Format("{0}\\Bitacora.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            try
            {
                reader = new XmlTextReader(path);
                ser = new XmlSerializer(typeof(T));
                retorno = (T)ser.Deserialize(reader);
            }
            catch (ErrorArchivoException exc)
            {
                throw new ErrorArchivoException("Error en Leer XML", exc);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return retorno;
        }
    }
}
