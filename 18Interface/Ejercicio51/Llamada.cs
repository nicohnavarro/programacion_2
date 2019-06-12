using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    #region Nested Types
    public enum TipoLlamada
    {
        Local, Provincial, Todas
    }
    #endregion

    public class Llamada
    {
        #region Llamada Atributtes
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Llamada Properties 
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Llamada Builder
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Llamada Methods
        public virtual string Mostrar()
        {
            string mostrar;
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendFormat("Duracion: {0}\nNumero de Origen: {1}\nNumero de Destino: {2}", this.Duracion, this.NroDestino, this.NroOrigen);
            mostrar = mensaje.ToString();
            return mostrar;
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }
            return retorno;
        }
        #endregion
    } 
}
