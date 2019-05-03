using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class Vehiculo
    {
        protected DateTime _ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length<6)
                {
                    this.patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("*********************************************");
            informacion.AppendFormat("{0} \nFecha: {1} \nHora: {2}\n", this.ToString(), _ingreso.Date, _ingreso.Hour);
            return informacion.ToString();
        }

        public static bool operator==(Vehiculo v1,Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.Equals(v2) ? true : false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }

        public override string ToString()
        {
            return String.Format("Patente {0}", Patente);
        }

        public Vehiculo(string patente)
        {
            Patente = patente;
            this._ingreso = DateTime.Now.AddHours(-3);
        }

    }
}
