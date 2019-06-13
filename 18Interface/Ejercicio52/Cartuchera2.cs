using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Cartuchera2
    {
        public List<Lapiz> lapices;
        public List<Boligrafo> boligrafos;

        public Cartuchera2()
        {
            lapices = new List<Lapiz>();
            boligrafos = new List<Boligrafo>();
        }

        public bool ProbarElementos()
        {
            bool retorno=true;
            foreach(Lapiz l in lapices)
            {
                if (((IAcciones)l).UnidadesDeEscritura >= 1)
                {
                    ((IAcciones)l).UnidadesDeEscritura = -1;
                    
                }
                else
                {
                    retorno = false;
                    try
                    {
                        ((IAcciones)l).Recargar(1);
                    }
                    catch (NotImplementedException e)
                    {

                    }
                }
            }
            foreach (Boligrafo b in boligrafos)
            {
                if (b.UnidadesDeEscritura >= 1)
                {
                    b.UnidadesDeEscritura = -1;
                    
                }
                else
                {
                    retorno = false;
                    try
                    {
                        b.Recargar(1);
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
