using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";

            //Builder with one parametre
            Dolar dolar1 = new Dolar(2000);
            Euro euro1 = new Euro(1000);
            Pesos peso1 = new Pesos(10000);

            //Builder with two parametres
            Dolar dolar2 = new Dolar(1000,1);
            Euro euro2 = new Euro(500, 1.16f);
            Pesos peso2 = new Pesos(5000, 38.33f);

            //Builder with one parametre
            Dolar dolar3 = new Dolar(1500);
            Euro euro3 = new Euro(500);
            Pesos peso3 = new Pesos(2000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cotizaciones del Dia Respecto al DOLAR U$D: \nEuro: ${0} Peso: ${1}", 
                euro1.GetCotizacion(), peso1.GetCotizacion());
            Console.WriteLine("Cotizaciones del Dia Respecto al DOLAR U$D: \nEuro: ${0} Peso: ${1}\n",
                euro2.GetCotizacion(), peso2.GetCotizacion());

            //Explicit Casting
            euro1 = (Euro)dolar1;
            peso1 = (Pesos)dolar1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mi Cuenta 1: Tiene  ${0} Dolares = ${1,5:#,###.00} Euros - ${2,5:#,###.00} Pesos",
                dolar1.GetCantidad(),euro1.GetCantidad(),peso1.GetCantidad());
            //Explicit Casting
            //dolar2 = (Dolar)peso2;
            //euro2 = (Euro)peso2;
            Console.WriteLine("Mi Cuenta 2: Tiene  ${0,5:#,###.00} Dolares = ${1,5:#,###.00} Euros - ${2,5:#,###.00} Pesos",
                dolar2.GetCantidad(), euro2.GetCantidad(), peso2.GetCantidad());
            Console.WriteLine("Mi Cuenta 3: Tiene  ${0,5:#,###.00} Dolares = ${1,5:#,###.00} Euros - ${2,5:#,###.00} Pesos",
                dolar3.GetCantidad(), euro3.GetCantidad(), peso3.GetCantidad());
            //OverLoad of operators 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEntre mis cuentas 2 y 3 tengo:\nDistintos Dolares {0} \nIgual Euros {1}\nIgual Pesos {2}",
                (dolar2!=dolar3),(euro2==euro3),(peso2==peso3));


            Console.ReadKey();
        }
    }
}
