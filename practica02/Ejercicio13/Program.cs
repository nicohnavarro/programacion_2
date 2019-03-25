using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string binario;
            Console.WriteLine("Ingrese un numero decimal para convertir a binario: ");
            bool a = double.TryParse(Console.ReadLine(), out numero);
            binario = Conversor.DecimalBinario(numero);

            Console.WriteLine("El binario es [{0}]", binario);
            Console.ReadKey();

        }
    }
}
