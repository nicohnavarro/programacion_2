using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp:Vehiculo
    {
        private string modelo;
        static int valorHora;

        public override string ConsultarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("\nCONSULTA");
            informacion.AppendFormat("{0}\nModelo: {1}\nValor Hora: $ {2} \n", this.ToString(), this.modelo, PickUp.valorHora);
            return informacion.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp ? true : false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder info = new StringBuilder();
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - base._ingreso;
            int estadia = ts.Hours;
            float precio = estadia * valorHora;
            info.AppendFormat("Estadia:{0} - Costo de Estadia: ${1}\n\n",estadia,precio);
            return base.ImprimirTicket()+info.ToString();
        }
         static PickUp()
         {
            PickUp.valorHora = 70;
         }

        public PickUp(string patente,string modelo):base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo,int valorHora) : this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }
    }
}
