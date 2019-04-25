using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
     public class Conversor
     {
        public static string DecimalBinario(double n)
        {
            string cadena="";
            double numero = n;
            if (numero == 0)
            {
                cadena = "00000000";
            }
            if (numero>0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = '0' + cadena;
                    }
                    else
                    {
                        cadena = '1' + cadena;
                    }
                    numero = (int)numero / 2;
                }
            }
            return cadena;
        }
        public static double BinarioDecimal(string b)
        {
            double resultado=0;

            return resultado;
        }
            
     }
}