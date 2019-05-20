using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        public short CaballosDeFuerza { get; set; }

        public AutoF1(short numero,string escuderia) : base(numero, escuderia)
        {

        }
        public AutoF1(short numero,string escuderia,short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder sc = new StringBuilder();
            sc.Append(base.MostrarDatos());
            sc.AppendFormat("Caballos de Fuerza: {0}\n", CaballosDeFuerza);
            return sc.ToString();
        }

        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            bool retorno = false;
            if (a1==a2 && a1.Escuderia==a2.Escuderia)
                retorno = true;
            return retorno;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return (!(a1 == a2));
        }
    }
}
