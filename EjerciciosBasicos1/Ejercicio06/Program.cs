using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            Console.ForegroundColor = ConsoleColor.Green;
            int añoInicio=0;
            int añoFin;
            bool validarAñoIni;
            bool validarAñoFin;
            Console.WriteLine("Ingresa el año Inicial: ");
            validarAñoIni = int.TryParse(Console.ReadLine(), out añoInicio);
            Console.WriteLine("Ingresa el año Final: ");
            validarAñoFin = int.TryParse(Console.ReadLine(), out añoFin);

            for(int i=añoInicio;i<añoFin;i++)
            {
                if(i%4==0 || (i%400==0 && i%100==0))
                {
                    Console.WriteLine("{0} es bisiesto.", i);
                }
            }

            Console.ReadLine();
        }
    }
}
