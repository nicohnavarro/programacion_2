using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1 { get { return this.caja1; } }
        public Caja Caja2 { get { return this.caja2; } }
        public List<string> Clientes { get { return this.clientes; } }

        public Negocio(Caja caja1,Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas ...");
            foreach(string cliente in Clientes)
            {
                Thread.Sleep(1000);
                if(Caja1.FilaClientes.Count>Caja2.FilaClientes.Count)
                {
                    Caja2.FilaClientes.Add(cliente);
                }
                else
                {
                    Caja1.FilaClientes.Add(cliente);
                }
            }
        }
    }
}
