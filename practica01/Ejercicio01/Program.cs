using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo=int.MaxValue;
            int maximo=int.MinValue;
            int sumatoria=0;
            float promedio;
            //federicordavila@gmail.com
            //github FedeDavila1984
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese el numero {0}:", i + 1);
                bool a = int.TryParse(Console.ReadLine(), out numero);
                Console.WriteLine("Numero {0} = {1}", i + 1, numero);
                sumatoria += numero;
                if(numero<minimo)
                {
                    minimo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
            }
            promedio = sumatoria / 5;

            Console.WriteLine("minimo : {0} maximo : {1} promedio : {2}", minimo, maximo,promedio);
            Console.ReadLine();

        }
    }
}
