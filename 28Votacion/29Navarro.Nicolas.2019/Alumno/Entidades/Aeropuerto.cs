using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Aeropuerto<T> where T:IAvion
    {
        //Atributos
        private List<T> vuelos;


        //public List<T> Vuelos { get { return this.vuelos; } set { this.vuelos = value; } }
        //Constructor
        public Aeropuerto()
        {
            this.vuelos = new List<T>();
        }
        //Metodos
        public static explicit operator String(Aeropuerto<T> a)
        {
            int contador = 0;
            string retorno;
            foreach(T avionAux in a.vuelos)
            {
                if(avionAux.Estado==Avion.EstadoVuelo.Volando)
                {
                    contador++;
                }
            }
            retorno = string.Format("El Aeropuerto cuenta con {0} vuelos en estado Volando.", contador);
            return retorno;
        }

        public void FinalizarVuelos()
        {
            foreach(T avionAux in this.vuelos)
            {
                avionAux.Estrellar();
            }
        }

        public static int operator + (Aeropuerto<T> a,T vuelo)
        {
            a.vuelos.Add(vuelo);
            return (a.vuelos.Count * 50);

        }

    }
}
