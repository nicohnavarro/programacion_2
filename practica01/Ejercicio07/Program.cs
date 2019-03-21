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
            float importeCobrar;
            float liquidacion;
            int horasTrabajadas;
            string nombre;
            int antiguedad;
            float valorHora;
            float descuento;
            Console.Title = "Ejercicio Nro 08";
            Console.WriteLine("Ingrese el valor hora: ");
            valorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor antiguedad (en años): ");
            bool a = int.TryParse(Console.ReadLine(), out antiguedad);
            Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
            bool b = int.TryParse(Console.ReadLine(), out horasTrabajadas);
            Console.WriteLine("nombre: {1} valor hora: {0,-10:#,###.00} antiguedad: {2,10}", valorHora, nombre, antiguedad);
            Console.ReadKey();


            importeCobrar = valorHora * horasTrabajadas;
            liquidacion = antiguedad * 150;
            descuento = (importeCobrar+liquidacion)*0.13;
        }
    }
}
