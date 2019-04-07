using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Title = "Ejercicio Nro 21";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Fahrenheit temp1 = new Fahrenheit(32);
            Celsius temp2 = new Celsius(0);
            Kelvin temp3 = new Kelvin(273.15);
            
            Console.WriteLine("F°:{0} C°:{1} K°:{2}\n"
                ,temp1.GetCantidadGrados()
                , temp2.GetCantidadGrados()
                , temp3.GetCantidadGrados());
            Console.WriteLine("Suma entre ellos : \nF°+C° ={0} F°+K° ={1}" +
                "\nC°+F° ={2} C°+K° ={3} \nK°+F° ={4} K°+C° ={5}"
                ,(temp1+temp2).GetCantidadGrados(),(temp1+temp3).GetCantidadGrados()
                , (temp2 + temp1).GetCantidadGrados(), (temp2 + temp3).GetCantidadGrados()
                , (temp3 + temp1).GetCantidadGrados(), (temp3 + temp2).GetCantidadGrados());

            Console.ReadKey();
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
