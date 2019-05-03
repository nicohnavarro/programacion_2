using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente,ConsoleColor color):base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora):this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("*********************************************");
            informacion.AppendFormat("Color : {0} \n Valor Hora: $ {1} \n", this.color, Automovil.valorHora);
            return informacion.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil ? true : false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder info = new StringBuilder();
            int cantidadHoras;
            DateTime horaActual = DateTime.Now;
            cantidadHoras = horaActual.Hour - base._ingreso.Hour;

            info.AppendFormat("Costo de Estadia : ${0}", cantidadHoras * Automovil.valorHora);
            return this.ConsultarDatos() + base.ImprimirTicket();
        }
    }
}
