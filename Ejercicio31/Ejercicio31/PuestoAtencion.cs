using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class PuestoAtencion
    {
        static int numeroActual;
        Puesto puesto;

        static public int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cliente)
        {
            System.Threading.Thread.Sleep(5000);
            return true;
        }

        //Constructor de clase
        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            Caja1,Caja2
        }
    }
}
