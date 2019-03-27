using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double areaCuadrado;
            double piso;
            double altura;
            double areaTriangulo;
            double radio;
            double areaCirculo;

            Console.WriteLine("Ingrese lado del Cuadrado :");
            bool a = double.TryParse(Console.ReadLine(), out lado);
            areaCuadrado = CalculoDeArea.CalcularCuadrado(lado);
            Console.WriteLine("El area del Cuadrado de lado {0} es {1,10}", lado, areaCuadrado);
            Console.ReadKey();

            Console.WriteLine("Ingrese base del triangulo :");
            bool b = double.TryParse(Console.ReadLine(), out piso);
            Console.WriteLine("Ingrese Altura del triangulo :");
            bool c = double.TryParse(Console.ReadLine(), out altura);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(piso, altura);
            Console.WriteLine("El area del Triangulo de base {0} y altura {1} es {2,10}", piso, altura, areaTriangulo);
            Console.ReadKey();

            Console.WriteLine("Ingrese radio del Circulo:");
            bool d = double.TryParse(Console.ReadLine(), out radio);
            areaCirculo = CalculoDeArea.CalcularCirculo(radio);
            Console.WriteLine("El area del Circulo de radio {0} es {1,10:#,###.00}", radio, areaCirculo);
            Console.ReadKey();
        }
    }
}
