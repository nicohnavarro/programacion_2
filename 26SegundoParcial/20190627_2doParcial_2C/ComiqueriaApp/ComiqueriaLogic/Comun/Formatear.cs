using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class Formatear
    {
        public static string FormatearPrecio(this double precio)
        {
            return string.Format("$ {0:0.00}", precio);
        }
    }
}
