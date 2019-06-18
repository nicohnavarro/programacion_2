using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Nicolas", "Navarro");
            if(Persona.Guardar(persona1))
            {
                Console.WriteLine("Se ha guardardo...");
                Console.WriteLine(persona1.ToString());
            }
            Persona persona2 = new Persona();
            persona2=Persona.Leer(@"c:\ArchivoXML");
            Thread.Sleep(2000);
            Console.WriteLine(persona2.ToString());
            Console.ReadKey();
        }
    }
}
