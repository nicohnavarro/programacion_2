using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio56
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            string extension = ".txt";
            bool retorno = false;
            try
            {
                if(base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == extension)
                        retorno = true;
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .txt");
                    }
                }
            }catch(ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return retorno;
        }

        public bool Guardar(string ruta, string objeto)
        {
            if(ValidarArchivo(ruta,true))
            {
                GuardarComo(ruta, objeto);
            }
            return true;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(objeto);
            sw.Close();
            return true;
        }

        public string Leer(string ruta)
        {
            string retorno="";
            if(ValidarArchivo(ruta,true))
            {
                StreamReader sr = new StreamReader(ruta);
                retorno = sr.ReadToEnd();
                sr.Close();
            }
            return retorno;
        }
    }
}
