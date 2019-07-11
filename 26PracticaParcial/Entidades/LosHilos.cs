using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        private int id;
        private List<InfoHilo> misHilos;

        public delegate void Midelegado(string mensaje);
        public event Midelegado AvisoFin;

        public string Bitacora {
            get
            {
                string path = string.Format(@"{0}\bitacora.txt",
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(path);
                    return reader.ReadToEnd();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }

            set
            {
                string path = string.Format(@"{0}\bitacora.txt",
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(path, true);
                    writer.WriteLine(value);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
        }

        public LosHilos()
        {
            this.id = 0;
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = string.Format("Termino el hilo {0}.", id);
            this.Bitacora = mensaje;
            AvisoFin(this.Bitacora);
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 1)
                throw new CantidadInvalidaException();
            else if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    AgregarHilo(hilos);
                }
            }
            return hilos;
        }

        private static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;
            InfoHilo nuevoHiilo = new InfoHilo(hilos.id,hilos);
            return hilos;
        }
    }
}
