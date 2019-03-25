using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            Console.ForegroundColor = ConsoleColor.Green;

            string numeroIngresado;
            int numeroConvertido;

            int auxNumero;
            bool validar;
            int suma = 0;
            int suma2 = 0;

            Console.WriteLine("Ingrese su centro numerico: ");
            numeroIngresado = Console.ReadLine();
            validar = int.TryParse(numeroIngresado, out numeroConvertido);

            for(int j=numeroConvertido;j>0;j--)
            {
                for (int i = 1; i < j; i++)
                {
                    suma += i;
                }
                suma2 = j + 1;
                auxNumero = suma2;
                do
                {
                    auxNumero++;
                    suma2 += auxNumero;
                } while (suma2 < suma);
                if (suma == suma2)
                {
                    Console.WriteLine("El numero {0} es centro numerico.", j);
                }
                else
                {
                    Console.WriteLine("El  numero {0} no es centro numerico.", j);
                }
                suma = 0;
                suma2 = 0;
                auxNumero = 0;
            }
            Console.ReadKey();
        }
    }
}
