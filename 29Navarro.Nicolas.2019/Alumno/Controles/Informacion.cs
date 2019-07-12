using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    public static class Informacion
    {
        public static string LogAvion(this Aeropuerto<Vuelo> v)
        {
            string retorno = "";
            retorno = string.Format("{0} ", DateTime.Now.ToString());
            return retorno;
        }
    }
}
