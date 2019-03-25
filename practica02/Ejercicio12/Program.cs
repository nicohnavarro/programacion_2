using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumatoria = 0;
            char letra;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese numero a sumar: ");
                bool a = int.TryParse(Console.ReadLine(), out numero);
                sumatoria += numero;
                Console.WriteLine("Continuar ? (S/N): ");
                respuesta = Console.ReadLine();
                letra = respuesta[0];

            } while (ValidarRespuesta.ValidarS_N(letra));

            Console.WriteLine("La Sumatoria es {0}", sumatoria);
            Console.ReadKey();
        }
    }
}
