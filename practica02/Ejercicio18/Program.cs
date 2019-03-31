using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Ejercicio_18
    {

        static void Main(string[] args)
        {
            Console.Title="Ejercicio Nro 18";
            Punto punto1 = new Punto(0, 0);
            Punto punto3 = new Punto(6, 6);

            Rectangulo rectangulo1 = new Rectangulo(punto1, punto3);
            Console.WriteLine(Rectangulo.ShowRectangulo(rectangulo1));
            Console.ReadKey();
        }
    }
}
