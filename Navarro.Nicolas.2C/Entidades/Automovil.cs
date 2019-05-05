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
        private static int valorHora;

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
            informacion.AppendLine("\nCONSULTA");
            informacion.AppendFormat("{0}\nColor: {1}\nValor Hora: $ {2}\n",this.ToString(), this.color, Automovil.valorHora);
            return informacion.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil ? true : false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder info = new StringBuilder();
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - base._ingreso;
            int estadia = ts.Hours;
            float precio=estadia*valorHora;
            info.AppendFormat("Estadia: {0} - Costo de Estadia : ${1}\n\n",estadia,precio);
            return base.ImprimirTicket() +info.ToString();
        }

        public override int GetHashCode()
        {
            return 790427672 + color.GetHashCode();
        }
    }
}
