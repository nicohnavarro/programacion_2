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
            informacion.AppendLine("*********************************************");
            informacion.AppendFormat("Modelo : {0} \n Valor Hora: $ {1} \n", this.modelo, PickUp.valorHora);
            return informacion.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp ? true : false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder info = new StringBuilder();
            int cantidadHoras;
            DateTime horaActual = DateTime.Now;
            cantidadHoras = horaActual.Hour - base._ingreso.Hour;

            info.AppendFormat("Costo de Estadia : ${0}", cantidadHoras * PickUp.valorHora);
            return this.ConsultarDatos() + base.ImprimirTicket();
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
