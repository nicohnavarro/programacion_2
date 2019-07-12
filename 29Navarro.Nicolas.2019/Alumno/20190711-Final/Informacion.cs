using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190711_Final
{
    public static class Informacion
    {
        public static string LogAvion(this Aeropuerto<Vuelo> v, int horas)
        {
            string retorno = "";
            retorno = string.Format("{0}-Horas: {1}\n", DateTime.Now.ToString(), horas);
            return retorno;
        }
    }
}
