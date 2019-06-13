using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        #region Provincial Atributtes
        protected Franja franjaHoraria;
        #endregion

        #region Provincial Properties
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Provincial Builders
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Provincial Methods

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        costo = base.Duracion * 0.99f;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        costo = base.Duracion * 1.25f;
                        break;
                    }
                case Franja.Franja_3:
                    {
                        costo = base.Duracion * 0.66f;
                        break;
                    }
            }
            return costo;
        }

        public override string Mostrar()
        {
            string mostrar;
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendFormat("{0}\nCosto de Llamada Provincial: ${1}\nFranja Horaria:{2}\n", base.Mostrar(), CostoLlamada, franjaHoraria);
            mostrar = mensaje.ToString();
            return mostrar;
        }
        #endregion

        #region Provincial Nested Types
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        #endregion

        public bool Guardar()
        {
            throw new NotImplementedException();
        }
        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
        public string RutaDeArchivo { get; set; }
    }
}
