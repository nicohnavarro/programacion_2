using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        public DirectorTecnico(string nombre,string apellido,int edad,int dni,int añosExperiencia):base(nombre,apellido,edad,dni)
        {
            AñosExperiencia=añosExperiencia;
        }
        public override string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendFormat("{0}", base.Mostrar());
            informacion.AppendFormat("Años de Experiencia: {0}", AñosExperiencia);
            return informacion.ToString();
        }
        public override bool ValidarAptitud()
        {
            bool retorno=false;
           if(base.Edad<65 && this.AñosExperiencia>2)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
