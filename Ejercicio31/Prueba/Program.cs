using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio31;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio1 = new Negocio("Negocio 1");
            Cliente cliente1 = new Cliente(0,"Juan");
            Cliente cliente2 = new Cliente(1, "Pedro");
            Cliente cliente3 = new Cliente(2, "Martin");

            negocio1.Cliente = cliente1;
            negocio1.Cliente = cliente2;
            negocio1.Cliente = cliente3;
            negocio1.Cliente = cliente1;
            Console.WriteLine("se atendiendo...");
            if (~negocio1)
            {
                Console.WriteLine("se atendio...");
            }
            if((negocio1+cliente1))
            {
                Console.WriteLine("ya esta en la lista");
            }
            Console.ReadKey();
        }
    }
}
