using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaBoligrafo = GetTinta();
            if(tinta<0)
            {
                this.tinta += tinta;
                if(this.tinta<0)
                {
                    this.tinta = 0;
                }
            }
            if(tinta>0 && (tintaBoligrafo+tinta)<=cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            short tintaARecargar;
            short tintaBoligrafo = GetTinta();

            tintaARecargar =(short)(cantidadTintaMaxima - tintaBoligrafo);

            SetTinta(tintaARecargar);
        }

        public bool Pintar(int gasto,out string dibujo)
        {
            bool retorno = true;
            short gastoTinta;
            short tintaBoligrafo=GetTinta();
            short cantidadSobrante;
            gastoTinta = (short)(gasto - (gasto * 2));
            cantidadSobrante = (short)(gasto - tintaBoligrafo);
            dibujo = "";
            if (tintaBoligrafo>0)
            {
                SetTinta(gastoTinta);
                
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }

            return retorno;
        }
    }
}
