using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio67
{

    public delegate void TempDelegado();
    public sealed class Temporizador
    {

        public event TempDelegado EventoTiempo;
     
        private int interval;
        private bool isCorriendo;
        
        
        public int Intervalo
        {
            get
            {
                return this.interval;
            }
            set
            {
                this.interval=value;
            }
        }

        public Temporizador(int intervalo)
        {
            this.interval = intervalo;
            this.isCorriendo = false;
        }

        public void Corriendo()
        {
            this.isCorriendo = true;
            do
            {
                System.Threading.Thread.Sleep(this.Intervalo);
                this.EventoTiempo();
            } while (this.isCorriendo);
        }


    }
}
