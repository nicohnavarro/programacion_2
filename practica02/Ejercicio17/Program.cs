using Ejercicio16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            string pintura;

            Console.ForegroundColor = boligrafo1.GetColor();
            boligrafo1.Pintar(50,out pintura);
            Console.WriteLine(pintura);

            Console.ForegroundColor = boligrafo2.GetColor();
            boligrafo2.Pintar(50,out pintura);
            Console.WriteLine(pintura);

            Console.ForegroundColor =ConsoleColor.White;
            Console.WriteLine("Tinta Boligrafo 1 :{0}", boligrafo1.GetTinta());
            Console.WriteLine("Tinta Boligrafo 2 :{0}", boligrafo2.GetTinta());
            boligrafo2.Recargar();
            Console.WriteLine("RECARGA BOLIGRAFO 2 ...");
            Console.WriteLine("Tinta Boligrafo 1 :{0}", boligrafo1.GetTinta());
            Console.WriteLine("Tinta Boligrafo 2 :{0}", boligrafo2.GetTinta());

            Console.ReadKey();

        }
    }
}
