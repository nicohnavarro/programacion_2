using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(2);

            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Cantidad de Sumas en 1: {0}", (int)sumador1);
            Console.WriteLine("Cantidad de Sumas en 2: {0}", (int)sumador2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Suma de enteros: 10 + 20 = {0}",sumador1.Sumar(10,20));
            Console.WriteLine("Suma de Textos: 10 + 20 = {0}",sumador1.Sumar("10","20"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cantidad de Sumas en 1: {0}", (int)sumador1);
            Console.WriteLine("Cantidad de Sumas en 2: {0}", (int)sumador2);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cantidad de sumas entre ambos : {0}", sumador1 + sumador2);
            Console.WriteLine("Comparacion entre Cantidad de sumas entre ambos : {0}", sumador1 | sumador2);

            
            Console.ReadKey();
        }
    }
}
