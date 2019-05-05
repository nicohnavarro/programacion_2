using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if(this+value)
                {

                }
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(0);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator !=(Negocio negocio,Cliente cliente)
        {
            return !(negocio == cliente);
        }
        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            foreach (Cliente clienteAux in negocio.clientes)
            {
                if (cliente == clienteAux)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator ~(Negocio negocio)
        {
            bool retorno = false;
            if(negocio.caja.Atender(negocio.Cliente))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            if(negocio!=cliente)
            {
                negocio.clientes.Enqueue(cliente);
                retorno = true;
            }
            return retorno;
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }

    }
}
