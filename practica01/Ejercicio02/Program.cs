using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int[] arrayNumeros = { 0, 0, 0, 0, 0 };
            int sumatoria=0;
            float promedio;
            int numeroMax=0;
            int numeroMin=9999;

            Console.WriteLine("Ingrese numero 1: ");
            arrayNumeros[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            arrayNumeros[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3: ");
            arrayNumeros[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 4: ");
            arrayNumeros[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 5: ");
            arrayNumeros[4] = int.Parse(Console.ReadLine());
            
            for(int i=0;i<arrayNumeros.Length;i++)
            {
                if (arrayNumeros[i]<numeroMin)
                {
                    numeroMin=arrayNumeros[i];
                }
                if (arrayNumeros[i] > numeroMax)
                {
                    numeroMax = arrayNumeros[i];
                }
                sumatoria = sumatoria + arrayNumeros[i];   
            }

            promedio = sumatoria / 5;
            Console.WriteLine("min {0} max {1} promedio {2}",numeroMin,numeroMax,promedio);
            Console.ReadLine();
        }
    }
}
