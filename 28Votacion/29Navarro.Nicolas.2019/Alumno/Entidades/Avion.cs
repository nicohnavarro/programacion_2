using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : IAvion
    {
        //Enumerado
        public enum EstadoVuelo
        {
            Programado,
            Volando,
            Aterrizado
        }
        //Atributos
        private int horasVuelo;
        private Thread vuelo;

        //Prop Interfaz
        public EstadoVuelo Estado
        {
            get
            {
                EstadoVuelo retorno=0;
                if(vuelo.ThreadState==ThreadState.Unstarted)
                {
                    retorno = EstadoVuelo.Programado;
                }
                else if(vuelo.IsAlive)
                {
                    retorno = EstadoVuelo.Volando;
                }
                else if(!vuelo.IsAlive && vuelo.ThreadState!=ThreadState.Unstarted)
                {
                    retorno = EstadoVuelo.Aterrizado;
                }
                return retorno;
            }
        }
        //Prop
        public int HorasDeVuelo
        {
            get
            {
                return this.horasVuelo;
            }
        }

        //Constructor
        public Avion(int horasDeVuelo)
        {
            this.horasVuelo = horasDeVuelo;
        }

        /// <summary>
        /// Metodo Volar
        /// </summary>
        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
            
                Thread.Sleep(1000);
                horasRestantes -= 1;
                ReportarEstado(this.HorasDeVuelo, horasRestantes);
            }
        }

        public void Despegar()
        {
            vuelo = new Thread(Volar);
            vuelo.Start();
        }

        public void Estrellar()
        {
            if(vuelo.IsAlive)
            {
                vuelo.Abort();
            }
        }

        public event ReporteDeEstado ReportarEstado;
    }
    public delegate int ReporteDeEstado(int horasTotales, int horasRestantes);
}
