using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Caja
    {
        private List<string> filaClientes;
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            for (int i = 0; i < FilaClientes.Count; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Atendiendo a :"+ FilaClientes[i]+" En :"+ Thread.CurrentThread.Name);
            }

            
        }
        public Caja()
        {
            filaClientes = new List<string>();
        }

    }
}
