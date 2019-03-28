using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1;
            Alumno alumno2;
            Alumno alumno3;


            alumno1 = new Alumno();        
            alumno1.apellido = "Perez";
            alumno1.legajo = 1;
            alumno1.nombre = "Juan";

            alumno2 = new Alumno();
            alumno2.apellido = "Rodriguez";
            alumno2.legajo = 2;
            alumno2.nombre = "Pedro";

            alumno3 = new Alumno();
            alumno3.apellido = "Gonzalez";
            alumno3.legajo = 3;
            alumno3.nombre = "Martin";

            alumno1.Estudiar(10, 9);
            alumno2.Estudiar(6, 6);
            alumno3.Estudiar(7, 2);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar() + alumno2.Mostrar() + alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
