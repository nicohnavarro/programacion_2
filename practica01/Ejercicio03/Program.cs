using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;
            do
            {
                Console.WriteLine("Ingrese el numero 0 < :");
                bool a = int.TryParse(Console.ReadLine(), out numero);
                if (numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    
                }
            } while (numero <= 0);
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado es :{0} ", cuadrado);
            Console.WriteLine("El cubo es : {0}", cubo);
            Console.ReadLine();

        }
    }
}
