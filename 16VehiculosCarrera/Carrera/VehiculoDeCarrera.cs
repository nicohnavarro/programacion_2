using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible { get; set; }
        public bool EnCompetencia { get; set; }
        public string Escuderia { get; set; }
        public short Numero { get; set; }
        public short VueltasRestantes { get; set; }

        public virtual string MostrarDatos()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("Cantidad de Combustible: {0}\n",this.CantidadCombustible);
            sc.AppendFormat("En Competencia :{0}\n",this.EnCompetencia);
            sc.AppendFormat("Escuderia :{0}\n",this.Escuderia);
            sc.AppendFormat("Numero :{0}\n",this.Numero);
            sc.AppendFormat("Vueltas Restantes: {0}\n",this.VueltasRestantes);
            return sc.ToString();
        }

        public VehiculoDeCarrera(short numero,string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            bool retorno = false;
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
                retorno = true;
            return retorno;
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return (!(a1 == a2));
        }
    }
}
