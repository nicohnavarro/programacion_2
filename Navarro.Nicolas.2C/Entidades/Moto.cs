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
            informacion.AppendLine("*********************************************");
            informacion.AppendFormat("Cilindrada : {0} \nRuedas: {1} \nValor Hora: ${2}\n", this.cilindrada, this.ruedas, Moto.valorHora);
            return informacion.ToString();  
        }

        public override bool Equals(object obj)
        {
            return obj is Moto?true:false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder info = new StringBuilder();
            int cantidadHoras;
            DateTime horaActual = DateTime.Now;
            cantidadHoras = horaActual.Hour - base._ingreso.Hour;

            info.AppendFormat("Costo de Estadia : ${0}",cantidadHoras*Moto.valorHora);
            return this.ConsultarDatos()+base.ImprimirTicket();
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
