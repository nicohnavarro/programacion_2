using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class MotoCross:VehiculoDeCarrera
    {
        private short cilindrada;
        public short Cilindrada { get {return this.cilindrada; } set {this.cilindrada=value; } }

        public override string MostrarDatos()
        {
            StringBuilder sc = new StringBuilder();
            sc.Append(base.MostrarDatos());
            sc.AppendFormat("Cilindrada: {0}\n", Cilindrada);
            return sc.ToString();
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }
        public MotoCross(short numero,string escuderia,short cilindrada):this(numero,escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross m1,MotoCross m2)
        {
            bool retorno = false;
            if (m1.Cilindrada == m2.Cilindrada)
                retorno = true;
            return retorno;
        }
        public static bool operator !=(MotoCross m1,MotoCross m2)
        {
            return (!(m1 == m2));
        }
    }
}
