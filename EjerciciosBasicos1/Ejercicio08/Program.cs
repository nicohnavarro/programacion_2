using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int niveles;
            
            Console.Title = "Ejercicio Nro 09";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ingrese la cantidad de niveles de la piramide:");
            bool a = int.TryParse(Console.ReadLine(), out niveles);

            for(int i=1;i<=niveles;i++)
            {
                for(int j=1;j<=niveles;j++)
                {
                    Console.Write("");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
