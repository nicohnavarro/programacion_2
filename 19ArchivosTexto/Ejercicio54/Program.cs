using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = ("C:\\src\\" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt");
            //string inners = "";
            try
            {
                MiClaseErrores aux = new MiClaseErrores(1);
            }
            catch(UnaException e)
            {
                
                ArchivoTexto.Guardar(nombreArchivo,e.Message);
            }

            Console.WriteLine(ArchivoTexto.Leer(nombreArchivo));
            Console.ReadKey();
        }
    }
}
