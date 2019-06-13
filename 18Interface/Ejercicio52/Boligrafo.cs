using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Boligrafo:IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color { get; set; }
        public float UnidadesDeEscritura {get; set;}

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }
        public EscrituraWrapper Escribir(string texto)
        {
            string textoRetorno = "";
            foreach (char c in texto)
            {
                if (UnidadesDeEscritura >= 0.3f)
                {
                    UnidadesDeEscritura -= 0.3f;
                    textoRetorno += c;
                }
            }
            return new EscrituraWrapper(textoRetorno, this.Color);
        }
        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura += unidades;
            return true;
        }
        public override string ToString()
        {
            return string.Format("Boligrafo Color: {0} Tinta: {1:0.00}", Color, UnidadesDeEscritura);
        }

    }
}
