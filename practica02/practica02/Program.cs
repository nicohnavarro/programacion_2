using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i;
            int sumatoria=0;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            float promedio;
            for (i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero entre el rango de -100 y 100: ");
                bool a = int.TryParse(Console.ReadLine(), out numero);
                if(Validacion.Validar(numero, -100, 100)==true)
                {
                    Console.WriteLine("Numero dentro del rango.");
                    if(numero<minimo)
                    {
                        minimo=numero;
                    }
                    if(numero>maximo)
                    {
                        maximo = numero;
                    }
                    sumatoria += numero;
                }
                else
                {
                    Console.WriteLine("Error de rango.");
                    i--;
                }
            }
            promedio = sumatoria / i + 1;
            Console.WriteLine("Valor maximo {0,10}- Valor minimo {1,10}- Promedio:{2,10:#,###.00}",maximo,minimo,promedio);
            Console.ReadKey();
        }
    }
}
