using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio67
{

    public delegate void encargadoTiempo();
    public sealed class Temporizador
    {

        public event encargadoTiempo EventoTiempo;
     
        private int intervalo;
        private Thread hilo;

        public bool Activo { get; set; }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo=value;
            }
        }

        public Temporizador(int intervalo)
        {
            Activo = false;
            this.Intervalo = intervalo;
            
        }

        public void Corriendo()
        {
            Activo = true;
            do
            {
                Thread.Sleep(this.Intervalo);
                EventoTiempo();
            } while (this.Activo);
        }
    }
}
