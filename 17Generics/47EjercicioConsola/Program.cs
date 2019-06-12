using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios47;

namespace _47EjercicioConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Torneos
            Torneo<EquipoFutbol> TorneoFutbol = new Torneo<EquipoFutbol>("SUPERLIGA ARGENTINA");
            Torneo<EquipoBasquet> TorneoBasquet = new Torneo<EquipoBasquet>("LIGA MANU");

            //Equipos Futbol
            EquipoFutbol equipo1 = new EquipoFutbol("River");
            EquipoFutbol equipo2 = new EquipoFutbol("Independiente");
            EquipoFutbol equipo3 = new EquipoFutbol("Racing");

            //Equipos Basquet
            EquipoBasquet equipoA = new EquipoBasquet("Chicago Bulls");
            EquipoBasquet equipoB = new EquipoBasquet("Golden State Warriors");
            EquipoBasquet equipoC = new EquipoBasquet("Los Angeles Lakers");

            //Agregar Futbol
            bool a = TorneoFutbol + equipo1;
            a = TorneoFutbol + equipo2;
            a = TorneoFutbol + equipo3;
            Console.WriteLine(TorneoFutbol.Mostrar());
            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.WriteLine(TorneoFutbol.JugarPartido);

            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
            Console.ReadKey();

            //Agregar Basquet
            bool b = TorneoBasquet + equipoA;
            b = TorneoBasquet + equipoB;
            b = TorneoBasquet + equipoC;
            Console.WriteLine(TorneoBasquet.Mostrar());
            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.WriteLine(TorneoBasquet.JugarPartido);

            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
            Console.ReadKey();
        }
    }
}
