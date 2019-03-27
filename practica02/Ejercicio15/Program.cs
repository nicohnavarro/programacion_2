using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double resultado;
            string respuesta;
            char operacion;
            Console.Write("INGRESE PRIMER NUMERO:");
            bool a = double.TryParse(Console.ReadLine(), out numero1);
            Console.Write("INGRESE SEGUNDO NUMERO:");
            bool b = double.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine("INGRESE OPERACION A REALIZAR ('+' '-' '*' '/')");
            respuesta = Console.ReadLine();
            operacion = respuesta[0];

            resultado= Calculadora.Calcular(numero1, numero2, operacion);
            Console.WriteLine("{0:#,###.00} {2} {1:#,###.00} ={3:#,###.00}", numero1,numero2,operacion,resultado);
            Console.ReadKey();

        }
    }
}
