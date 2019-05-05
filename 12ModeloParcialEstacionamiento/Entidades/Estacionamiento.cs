using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre,int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendFormat("Nombre: {0}\n", e.nombre);

            informacion.AppendFormat("Espacio Disponible : {0}\n", e.espacioDisponible - e.vehiculos.Count);
            foreach (Vehiculo vehiculo in e.vehiculos)
            {
                informacion.Append(vehiculo.ConsultarDatos());
                informacion.AppendLine();
            }
            return informacion.ToString();
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            string retorno;
            if(e.vehiculos!=null &&  e.vehiculos.Contains(v))
            {
                retorno=v.ImprimirTicket();
                e.vehiculos.Remove(v);
            }
            else
            {
                retorno = "\n-----NO ES PARTE DEL ESTACIONAMIENTO-----\n" + v.ConsultarDatos()+ "-.-.-.-.-.-.-.-\n";
            }
            return retorno;
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if((e!=v)  && (e.espacioDisponible>e.vehiculos.Count))
            {
                e.vehiculos.Add(v);
            }
            return e;
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno;
            if(estacionamiento.vehiculos.Contains(vehiculo))
            {
                retorno = true;
            }
            else
            {
                retorno= false;
            }
            return retorno;
        }

    }
}
