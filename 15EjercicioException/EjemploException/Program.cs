using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float resultado;
                resultado = Division.Dividir();
            }
            catch(DivideByZeroException de)
            {
                try
                {
                    throw new MiException(de.Message, de);
                }
                //Console.WriteLine(de.Message);
                catch(MiException MiE)
                {
                    Console.WriteLine(MiE.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
