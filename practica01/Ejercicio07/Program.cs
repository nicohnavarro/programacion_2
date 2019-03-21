using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            string nombre;
            int antiguedad;
            float valorHora;
            Console.Title = "Ejercicio Nro 07";
            Console.WriteLine("Ingrese el valor hora: ");
            bool a = float.TryParse(Console.ReadLine(),out valorHora);
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor antiguedad (en años): ");
            bool b = int.TryParse(Console.ReadLine(), out antiguedad);
            Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
            bool c = int.TryParse(Console.ReadLine(), out horasTrabajadas);
            Console.WriteLine("nombre: {1} valor hora: {0,-10:#,###.00} antiguedad: {2,10}", valorHora, nombre, antiguedad);
            Console.ReadKey();
        }
    }
}
