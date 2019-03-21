using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            Console.ForegroundColor = ConsoleColor.Green;
            int cantNumeroPerf = 0;
            int sumatoria = 0;
            for(int i=1;i<100;i++)
            {
                for(int j=1;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        sumatoria += i;
                        //Console.WriteLine("sumatoria {0}", sumatoria);
                    }
                }
                if (sumatoria == i)
                {
                    Console.WriteLine("El numero es PERFECTO: {0}", i);
                    cantNumeroPerf++;
                    if(cantNumeroPerf==4)
                    {
                        Console.WriteLine("Hasta {0} Numero Perfecto", cantNumeroPerf);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("El numero NO es perfecto: {0}", i);
                }

            }
            Console.ReadLine();
        }
    }
}
