using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double resultado = 0;
            resultado = lado * lado;
            return resultado;
        }
        public static double CalcularTriangulo(double piso ,double altura )
        {
            double resultado = 0;
            resultado = (piso * altura) / 2;
            return resultado;
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado = 0;
            resultado = Math.PI * (radio * radio);
            return resultado;
        }

    }
}
