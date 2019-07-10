using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class ArchivoTexto
    {
        public static bool Escribir(IArchivoTexto archivo,bool append)
        {
            StreamWriter writer=null;
            bool escribio = false;
            try
            {
                writer = new StreamWriter(archivo.Ruta, append, Encoding.UTF8);
                writer.Write(archivo.Texto);
                writer.WriteLine("----------------------------------------------------");
                writer.Close();
                escribio = true;
            }
            catch(Exception e)
            {
                escribio = false;
                throw e;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return escribio;
        }

        public static string Leer(string ruta)
        {
            string leyoTexto;
            StreamReader reader=null;
            try
            {
                reader = new StreamReader(ruta);
                leyoTexto = reader.ReadToEnd();
                reader.Close();
                
            }
            catch(FileNotFoundException e)
            {
                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return leyoTexto;
        }
    }
}
