using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool exit=false;
            if(valor<max && valor>min)
            {
                exit = true;
            }
        
            return exit;
        }
    }
}
