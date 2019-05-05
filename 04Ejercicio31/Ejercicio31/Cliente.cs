using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Cliente
    {
        string nombre;
        int numero;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre):this(numero)
        {
            this.Nombre=nombre;
        }

        /// <summary>
        /// Overload of operator !=
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;
            if(cliente1.Numero!=cliente2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator ==
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;
            if(!(cliente1!=cliente2))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
