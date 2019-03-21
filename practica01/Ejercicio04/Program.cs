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

                if (numero % i == 0)
                {
                    dividendos++;
                }
            }
            if (dividendos != 2)
            {
                Console.WriteLine("No es Primo");
            }
            else
            {
                Console.WriteLine("Si es Primo");
            }
            Console.ReadLine();
        }
        
    }
}
