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
                if(value.Length==6)
                {
                    this.patente = value;
                }
                else
                {
                    this.patente = "Error de Patente";
                }
            }
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("*****************************");
            informacion.AppendFormat("{0}\nFecha de Ingreso: {1}\nFecha de Egreso: {2}\n", this.ToString(), _ingreso.TimeOfDay,DateTime.Now.TimeOfDay);
            return informacion.ToString();
        }

        public static bool operator==(Vehiculo v1,Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.Equals(v2) && v1.GetType()==v2.GetType() ? true : false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }

        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Patente: {0}", this.Patente);

            return mostrar.ToString();
        }

        public Vehiculo(string patente)
        {
            Patente = patente;
            this._ingreso = new DateTime();
            this._ingreso = DateTime.Now.AddHours(-3);
        }

    }
}
