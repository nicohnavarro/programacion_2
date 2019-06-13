using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ejercicio54
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string filepath, string info)
        {
            StreamWriter sw = new StreamWriter(filepath);
            sw.WriteLine(info);
            sw.Close();
            return true;
        }

        public static string Leer(string filepath)
        {
            string infoRetorno="";
            if(File.Exists(filepath))
            {
                StreamReader sr = new StreamReader(filepath);
                infoRetorno = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
            return infoRetorno;
        }
    }
}
