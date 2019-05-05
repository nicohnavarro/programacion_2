using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas=2;
        static int valorHora;

        public override string ConsultarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("\nCONSULTA");
            informacion.AppendFormat("{0}\nCilindrada : {1}\nRuedas: {2}\nValor Hora: ${3}\n",this.ToString(), this.cilindrada, this.ruedas, Moto.valorHora);
            return informacion.ToString();  
        }

        public override bool Equals(object obj)
        {
            return obj is Moto?true:false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder info = new StringBuilder();
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - base._ingreso;
            int estadia;
            estadia = ts.Hours;
            float precio;
            precio = estadia * valorHora;
            //DateTime horaActual = DateTime.Now;
            info.AppendFormat("Estadia: {0} - Costo de Estadia : ${1}\n\n", estadia,precio);
            return base.ImprimirTicket()+info.ToString();
        }
        static Moto()
        {
            Moto.valorHora = 30;
        }

        public Moto(string patente,int cilindrada):base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente,int cilindrada,short ruedas):this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente,int cilindrada, short ruedas,int valorHora):this(patente,cilindrada,ruedas)
        {
            Moto.valorHora = valorHora;
        }
    }
}
