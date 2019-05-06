using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }

    public class Provincial:Llamada
    {
        

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costoTotal=0;
            switch((int)this.franjaHoraria)
            {
                case 0:
                    costoTotal = base.Duracion * 0.99f;
                    break;
                case 1:
                    costoTotal = base.Duracion * 1.25f;
                    break;
                case 2:
                    costoTotal = base.Duracion * 0.66f;
                    break;                
            }
            return costoTotal;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("{0}", base.Mostrar());
            sc.AppendFormat("Franja Horaria: {0}\n", this.franjaHoraria);
            sc.AppendFormat("Costo de Llamada: ${0}\n", this.CostoLlamada);

            return sc.ToString();
        }

        public Provincial(Franja miFranja,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial (string origen,Franja miFranja,float duracion,string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
