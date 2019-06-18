using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio56
{
    [Serializable]
    class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido { get => contenido; set => contenido = value; }

        public PuntoDat()
        {

        }
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            string extension = ".dat";
            
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == extension)
                        return true;
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                    }
                }
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return true;
        }
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            try
            {
                if (base.ValidarArchivo(ruta, true))
                    return GuardarComo(ruta,objeto);
            }
            catch (ArchivoIncorrectoException)
            {

            }
            return false;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {

            FileStream fs = new FileStream(ruta, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, objeto);
            fs.Close();
            return true;

        }

        public PuntoDat Leer(string ruta)
        {
            try
            {
                if (base.ValidarArchivo(ruta, true))
                {
                    FileStream fs = new FileStream(ruta, FileMode.Open);
                    BinaryFormatter ser = new BinaryFormatter();
                    PuntoDat puntoDat = (PuntoDat)ser.Deserialize(fs);
                    fs.Close();
                    return puntoDat;
                }
            }
            catch (ArchivoIncorrectoException)
            {

            }
            return null;
        }
    }
}
