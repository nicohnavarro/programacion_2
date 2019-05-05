using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada { get;}

        public float Duracion { get {return this._duracion; } }

        public string NroDestino { get { return this._nroDestino; } }

        public string NroOrigen { get {return this._nroOrigen; } }

        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("Duracion : {0}\n", this.Duracion);
            sc.AppendFormat("Numero de Destino : {0}\n", this.NroDestino);
            sc.AppendFormat("Numero de Origen : {0}\n", this.NroOrigen);
            return sc.ToString();
        }

        public static bool operator !=(Llamada llamada1,Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            bool retorno = false;
            if (llamada1.Equals(llamada2) 
                && llamada1.NroDestino==llamada2.NroDestino
                && llamada1.NroOrigen==llamada2.NroOrigen)
                retorno = true;
            return retorno;
        }

        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int retorno=0;
            if (llamada1.Duracion < llamada2.Duracion)
                retorno = 1;
            else if (llamada1.Duracion > llamada2.Duracion)
                retorno = -1;
            return retorno;
        }
    }
}
