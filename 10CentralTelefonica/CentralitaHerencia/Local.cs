﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        #region Local Atributtes
        protected float costo;
        #endregion

        #region Local Properties
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Local Builders
        public Local(Llamada llamada,float costo): base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino,float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        #endregion

        #region Local Methods
        private float CalcularCosto()
        {
            float costoTotal;
            costoTotal = costo* base.Duracion;
            return costoTotal;
        }

        public override string Mostrar()
        {
            string mostrar;
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendFormat("{0}\nCosto de Llamada Local: ${1}\n", base.Mostrar(), this.CostoLlamada);
            mostrar = mensaje.ToString();
            return mostrar;
        }
        #endregion
    }
}
