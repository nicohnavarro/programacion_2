using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploException
{
    public class Division
    {
        static int numero1;
        static int numero2;

        static Division()
        {
            numero1 = 20;
            numero2 = 0;
        }

        public static float Dividir()
        {
            float resultado;
            resultado = numero1 / numero2;
            return resultado;
        }
    }
}
