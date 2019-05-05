using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0f;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            
        }

        public string MostrarDatos()
        {
            StringBuilder infoJugador = new StringBuilder();
            string showPlayer;

            infoJugador.AppendFormat("- Nombre {0} \n- Dni:{1} \n- Cantidad Partidos {2} \n- Total de Goles: {3} \n- Promedio de Gol: {4}\n",
                this.nombre, this.dni, this.partidosJugados, this.totalGoles, GetPromedioGoles());
            showPlayer = infoJugador.ToString();
            return showPlayer;
        }

        public float GetPromedioGoles()
        {
            float promedio;
            promedio = this.totalGoles / this.partidosJugados;
            return promedio;
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;
            if (jugador1.dni == jugador2.dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;
            if (!(jugador1 == jugador2))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
