using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicios47
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;
            foreach (T equipoAux in torneo.equipos)
            {
                if (equipoAux == equipo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return (!(torneo == equipo));
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                retorno = true;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("Nombre del Torneo: {0}\n\n", this.nombre);
            sc.AppendLine("Equipos: \n");
            foreach (T equipoAux in this.equipos)
            {
                sc.AppendFormat("{0}", equipoAux.Ficha());
            }
            return sc.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            string retorno = "";
            int resultado1;
            int resultado2;
            if(equipo1 is EquipoFutbol && equipo2 is EquipoFutbol)
            {
                Thread.Sleep(500);
                resultado1 = new Random().Next(1, 10);
                Thread.Sleep(1000);
                resultado2 = new Random().Next(1, 10);
                retorno= String.Format("{0} {1} - {2} {3}\n", equipo1.nombre, resultado1, resultado2, equipo2.nombre);
            }
            else if(equipo1 is EquipoBasquet && equipo2 is EquipoBasquet)
            {
                Thread.Sleep(500);
                resultado1 = new Random().Next(1, 130);
                Thread.Sleep(1000);
                resultado2 = new Random().Next(1, 130);
                retorno = String.Format("{0} {1} - {2} {3}\n", equipo1.nombre, resultado1, resultado2, equipo2.nombre);
            }
            return retorno;
        }

        private T DarEquipo()
        {
            T retorno = null;
            if (equipos.Count > 0)
            {
                Thread.Sleep(1000);
                int random = new Random().Next(1, equipos.Count + 1);
                retorno = equipos[random - 1];
            }
            return retorno;
        }

        public string JugarPartido
        {
            get
            {
                string retorno="";
                if(equipos.Count>1)
                {
                    T equipo1;
                    T equipo2;
                    do
                    {
                        equipo1 = DarEquipo();
                        equipo2 = DarEquipo();
                        if (equipo1 != equipo2)
                        {
                            break;
                        }
                    } while (true);
                    retorno = CalcularPartido(equipo1, equipo2);
                }
                return retorno;
            }
        }
    }
}

