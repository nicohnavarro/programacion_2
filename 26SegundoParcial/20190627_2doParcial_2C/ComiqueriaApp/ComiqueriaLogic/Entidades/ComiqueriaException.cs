using ComiqueriaLogic.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        { }

        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString());
                sb.AppendLine(this.Message);
                Exception miException = this;
                while(miException.InnerException!=null)
                {
                    sb.AppendLine(miException.InnerException.Message);
                    miException = miException.InnerException;
                }
                return sb.ToString();
            }
        }
        public string Ruta
        {
            get
            {
                string path = string.Format(@"{0}\log.txt", 
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                return path;
            }
        }
    }
}
