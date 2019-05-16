using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploException
{
    public class MiException:Exception
    {
        public MiException(string mensaje):base(mensaje)
        {

        }
        public MiException(string mensaje,Exception innerException):base(mensaje,innerException)
        {
            Console.WriteLine("Fallo2");
        }
        public override string Message => "MiError";
    }
}
