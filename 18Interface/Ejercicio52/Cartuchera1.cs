using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Cartuchera1
    {
        public List<IAcciones> utiles;

        public Cartuchera1()
        {
            this.utiles = new List<IAcciones>();
        }
        public bool ProbarElementos()
        {
            bool retorno = true;
            foreach(IAcciones ia in this.utiles)
            {
                
                if(ia.UnidadesDeEscritura>=1)
                {
                    ia.UnidadesDeEscritura = -1;
                   
                }
                else
                {
                    retorno = false;
                    try
                    {
                        ia.Recargar(1);
                    }
                    catch (NotImplementedException e)
                    {

                    }
                }
            }
            return retorno;
        }
    }
}
