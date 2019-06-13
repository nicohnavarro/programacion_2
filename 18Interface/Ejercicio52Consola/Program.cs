using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio52;

namespace Ejercicio52Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor colorOriginal = Console.ForegroundColor;
            //Lapiz miLapiz = new Lapiz(10);
            //Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            //IAcciones iAcciones = miLapiz;
            //EscrituraWrapper eLapiz = iAcciones.Escribir("Hola");
            //Console.ForegroundColor = eLapiz.color;
            //Console.WriteLine(eLapiz.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miLapiz);
            //EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            //Console.ForegroundColor = eBoligrafo.color;
            //Console.WriteLine(eBoligrafo.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miBoligrafo);
            //Console.ReadKey();

            //Ejercicio 53
            Cartuchera1 c1 = new Cartuchera1();
            Cartuchera2 c2 = new Cartuchera2();
            //Lapices y boligrafos
            Lapiz l1 = new Lapiz(8);
            Lapiz l2 = new Lapiz(3);
            Lapiz l3 = new Lapiz(1);
            Lapiz l4 = new Lapiz(0);
            Boligrafo b1 = new Boligrafo(3, ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(2, ConsoleColor.Blue);
            Boligrafo b3 = new Boligrafo(0, ConsoleColor.Gray);
            //
            c1.utiles.Add(l1);
            c1.utiles.Add(l2);
            c1.utiles.Add(l4);
            c1.utiles.Add(b1);
            c1.utiles.Add(b3);
            //
            c2.lapices.Add(l1);
            c2.lapices.Add(l4);
            c2.boligrafos.Add(b2);
            c2.boligrafos.Add(b3);
            
            Console.WriteLine(c1.ProbarElementos());
            Console.WriteLine(c2.ProbarElementos());
            Console.ReadKey();
        }
    }
}
