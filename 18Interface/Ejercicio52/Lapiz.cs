using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Lapiz :IAcciones
    {
        private float tamanioMina;
        private IAcciones IAcciones;

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            IAcciones = this;
            this.IAcciones.UnidadesDeEscritura = unidades;
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            IAcciones = this;
            string textoRetorno="";
            for(int i=0;i<texto.Length;i++)
            {
                if(IAcciones.UnidadesDeEscritura>=0.1f)
                {
                    IAcciones.UnidadesDeEscritura -= 0.1f;
                    textoRetorno += texto[i];
                }
            }
            return new EscrituraWrapper(textoRetorno, IAcciones.Color);

        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            IAcciones = this;
            return string.Format("Lapiz Color: {0} Tinta: {1:0.00}",IAcciones.Color,IAcciones.UnidadesDeEscritura);
        }
    }
}
