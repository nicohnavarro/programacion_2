using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        private float CalcularCosto()
        {
            float costoTotal;
            costoTotal = costo * base.Duracion;
            return costoTotal;
        }

        public override bool Equals(object obj)
        {
            //return (obj.GetType() == typeof(Local));
            return obj is Local;
        }

        public Local(Llamada llamada,float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen,float duracion,string destino,float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("{0}", base.Mostrar());
            sc.AppendFormat("Costo de Llamada : ${0}\n", this.CostoLlamada);
            return sc.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
