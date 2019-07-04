using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using ComiqueriaLogic.Entidades;

namespace ComiqueriaLogic.Comun
{
    public static class Serializador<T> where T :class,new()
    {
        public static bool GuardarBinario(string path,T dato)
        {
            bool guardoBinario = false;
            FileStream fs=null;
            BinaryFormatter ser;

            try
            {
                fs = new FileStream(path, FileMode.Create);
                ser = new BinaryFormatter();
                ser.Serialize(fs, dato);
                fs.Close();
                guardoBinario = true;
            }
            catch(Exception e)
            {
                guardoBinario = false;
                throw e;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return guardoBinario;
        }

        public static bool GuardarXML(string path,T dato)
        {
            bool guardoXml=false;
            XmlTextWriter writer=null;
            XmlSerializer ser;
            try
            {
                writer = new XmlTextWriter(path, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, dato);
                writer.Close();
                guardoXml = true;
                //throw new DirectoryNotFoundException();
            }
            catch(ArgumentException e)
            {
                
                throw new ArgumentException(e.Message,e);
            }
            catch(DirectoryNotFoundException e)
            {
                ComiqueriaException comiqueriaException = new ComiqueriaException("Error: Directorio no encontrado", e);
                ArchivoTexto.Escribir(comiqueriaException, true);
                throw comiqueriaException;
            }
            catch(Exception e)
            {
                throw new Exception("Error Vaquero....", e);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return guardoXml;
        }

        public static T LeerXML(string path)
        {
            T leyoXml;
            XmlTextReader reader=null;
            XmlSerializer ser;
            try
            {
                reader = new XmlTextReader(path);
                ser = new XmlSerializer(typeof(T));
                leyoXml = (T)ser.Deserialize(reader);
                reader.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Error en Leer Xml ...",e);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return leyoXml;
        }

        public static T LeerBinario(string path)
        {
            T leyoBi;
            FileStream fs=null;
            BinaryFormatter ser;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                ser = new BinaryFormatter();
                leyoBi = (T)ser.Deserialize(fs);
                fs.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs!=null)
                {
                    fs.Close();
                }
            }
            return leyoBi;
        }
    }
}
