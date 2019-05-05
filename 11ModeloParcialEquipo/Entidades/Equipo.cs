using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public static explicit operator string(Equipo equipo)
        {
            StringBuilder informacion = new StringBuilder();
            if(equipo.directorTecnico ==null)
            {
                informacion.Append("Sin DT asignado\n");
            }
            else
            {
                informacion.AppendFormat("{0}", equipo.directorTecnico.Mostrar());
            }
            foreach(Jugador jugador in equipo.jugadores)
            {
                informacion.AppendFormat("{0}", jugador.Mostrar());
            }
            return informacion.ToString();
        }

        public static bool operator !=(Equipo equipo,Jugador jugador)
        {
            bool retorno = false;
            if(!(equipo==jugador))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;
            foreach(Jugador jugadorAux in equipo.jugadores)
            {
                if(jugador.Equals(jugadorAux))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static Equipo operator +(Equipo equipo,Jugador jugador)
        {
            if(equipo!=jugador && equipo.jugadores.Count< Equipo.cantidadMaximaJugadores && jugador.ValidarEstadoFisico())
            {
                equipo.jugadores.Add(jugador);
            }
            return equipo;
        }

        public static bool ValidarEquipo(Equipo equipo)
        {
            bool retorno = false;
            int arquero=0;
            bool defensor = false;
            bool central = false;
            bool delantero = false;

            if (equipo.directorTecnico!=null)
            {
                foreach(Jugador jugador in equipo.jugadores)
                {
                    if((int)jugador.Posicion==0)
                    {
                        arquero++;
                    }
                    if ((int)jugador.Posicion==1)
                    {
                        defensor = true;
                    }
                    if ((int)jugador.Posicion == 2)
                    {
                        central = true;
                    }
                    if ((int)jugador.Posicion == 3)
                    {
                        delantero = true;
                    }
                }
                if(arquero==1 && defensor && central && delantero && cantidadMaximaJugadores==equipo.jugadores.Count)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
