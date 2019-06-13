using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio67
{


    public sealed class Temporizador
    {
        public delegate void encargadoTiempo();
        public event encargadoTiempo EventoTiempo;

        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                bool retorno = false;
                if (hilo != null && hilo.IsAlive == true)
                {
                    retorno = true;
                }
                return retorno;
            }
            set
            {
                if ((value == true && hilo != null))
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
            }
        }
        public int Intevalo
        {
            get
            {
                return 0;
            }
            set
            {
                ;
            }
        }

        public Temporizador(int intervalo)
        {
            this.Intevalo = intervalo;
        }

        private void Corriendo()
        {
            while (true)
            {
                EventoTiempo();
                Thread.Sleep(this.Intevalo);
            }
        }


    }
}
