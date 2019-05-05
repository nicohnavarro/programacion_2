using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {

        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador1)
        {
            bool retorno = false;
            if(equipo.jugadores.Count()==0)
            {
                equipo.jugadores.Add(jugador1);
                retorno = true;
            }
            else
            {
                foreach (Jugador jugador2 in equipo.jugadores)
                {

                    if (jugador1 != jugador2 && equipo.jugadores.Count() < equipo.cantidadDeJugadores)
                    {
                        equipo.jugadores.Add(jugador1);
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
            }
            return retorno;
        }

        public string ShowTeam()
        {
            StringBuilder infoTeam = new StringBuilder();
            string infoEquipo;
            infoTeam.AppendFormat("Nombre {0} \nCantidad Jugadores {1} \nJugadores: \n",this.nombre,this.cantidadDeJugadores);
            foreach(Jugador jugador in this.jugadores)
            {
                infoTeam.AppendFormat("{0}", jugador.MostrarDatos());
            }

            infoEquipo = infoTeam.ToString();
            return infoEquipo;
        }
    }
}
