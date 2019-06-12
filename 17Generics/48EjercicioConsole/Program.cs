using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _48EjercicioLogic;

namespace _48EjercicioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de objetos y colecciones
            Contabilidad<Factura, Recibo> contabilidad1 = new Contabilidad<Factura, Recibo>();
            //Contabilidad<Recibo, Recibo> contabilidad2 = new Contabilidad<Recibo, Recibo>();

            Documento doc1 = new Recibo();
            Documento doc2 = new Factura(2);
            Documento doc3 = new Recibo(3);

            contabilidad1 += (Recibo)doc3;
            contabilidad1 += (Factura)doc2;
            foreach(Factura r in contabilidad1.egresos)
            {
                Console.WriteLine("numero {0}",r.numero);
            }

            Console.ReadKey();
        }
    }
}
