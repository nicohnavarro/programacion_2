using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char c)
        {
            double resultado=0;
            if(Calculadora.Validar(numero2)==true && c=='/')
            {
                resultado = numero1 / numero2;
            }
            
            if(c=='+')
            {
                resultado = numero1 + numero2;
            }
            if (c == '-')
            {
                resultado = numero1 - numero2;
            }
            if (c == '*')
            {
                resultado = numero1 * numero2;
            }
            return resultado;
        }
        private static bool Validar(double numero2)
        {
            bool resultado = true;
            if(numero2==0)
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
