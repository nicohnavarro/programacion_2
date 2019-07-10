using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T datos)
        {
            bool retorno = false;
            XmlTextWriter writer = null;
            XmlSerializer ser = null;

            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                retorno = true;
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error en el Archivo...", e);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return retorno;
        }

        public T Leer(string rutaArchivo)
        {
            T retorno;
            XmlTextReader reader= null;
            XmlSerializer ser = null;

            try
            {
                reader = new XmlTextReader(rutaArchivo);
                ser = new XmlSerializer(typeof(T));
                retorno = (T)ser.Deserialize(reader);
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al leer...", e);
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
