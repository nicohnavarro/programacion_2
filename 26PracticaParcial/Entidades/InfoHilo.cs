using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;

        private void Ejecutar()
        {
            Thread.Sleep(randomizer.Next(1, 5)*1000);
            callback.RespuestaHilo(id);
        }
        static InfoHilo()
        {
            randomizer = new Random();
        }
        public InfoHilo(int id,IRespuesta<int> callback)
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(Ejecutar);
            hilo.Start();
        }
    }
}
