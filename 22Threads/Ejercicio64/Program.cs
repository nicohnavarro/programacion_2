using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio1 = new Negocio(caja1, caja2);
            negocio1.Clientes.Add("Nicolas");
            negocio1.Clientes.Add("Melissa");
            negocio1.Clientes.Add("Omar");
            negocio1.Clientes.Add("Aline");
            negocio1.Clientes.Add("Mirta");
            negocio1.Clientes.Add("Lucas");
            negocio1.Clientes.Add("Lautaro");
            negocio1.Clientes.Add("Felipe");

            Thread hilo1 = new Thread(negocio1.AsignarCaja);
            Thread hilo2 = new Thread(caja1.AtenderClientes);
            hilo2.Name = "Caja 1";
            Thread hilo3 = new Thread(caja2.AtenderClientes);
            hilo3.Name = "Caja 2";
            hilo1.Start();
            hilo1.Join();
            hilo2.Start();
            hilo3.Start();

            Console.ReadKey();

        }
    }
}
