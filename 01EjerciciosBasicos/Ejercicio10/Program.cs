using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de niveles: ");
            bool a = int.TryParse(Console.ReadLine(), out int niveles);
            int auxNiveles=niveles;
            
            for(int i=0;i<niveles;i++)
            {
                for (int j=1;j<=auxNiveles;j++)
                {
                    Console.Write(" ");
                }
                auxNiveles--;
                for(int j=1;j<=i*2-1;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
