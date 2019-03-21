using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumatoria=0;
            Console.Title = "Ejercicio Nro 05";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese el numero :");
            bool a = int.TryParse(Console.ReadLine(), out numero);

            for(int i=1;i<numero;i++)
            {
                if(numero%i==0)
                {
                    sumatoria += i;
                    Console.WriteLine("sumatoria {0}", sumatoria);
                }
            }

            if(sumatoria==numero)
            {
                Console.WriteLine("El numero es PERFECTO: {0}", numero);
            }
            else
            {
                Console.WriteLine("El numero NO es perfecto: {0}", numero);
            }
            Console.ReadLine();
        }
    }
}
