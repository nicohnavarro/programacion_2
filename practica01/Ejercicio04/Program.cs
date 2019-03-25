using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int dividendos=0;
            Console.WriteLine("Ingrese el numero :");
            bool a = int.TryParse(Console.ReadLine(), out numero);

            for(int i=1;i<=numero;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (i % j == 0)
                    {
                        dividendos++;
                    }
                }
                
                if (dividendos ==1 || dividendos == 2)
                {
                    Console.WriteLine("{0}  es Primo", i);
                }
                else
                {
                   // Console.WriteLine("{0} No es Primo",i);
                }
                dividendos = 0;
            }
            Console.ReadLine();
        }

    }
}
