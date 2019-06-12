using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios47
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.fechaCreacion = new DateTime().Date;
        }

        public static bool operator==(Equipo equipo1,Equipo equipo2)
        {
            bool retorno = false;
            if (equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion)
                retorno = true;
            return retorno;
        }
        public static bool operator!=(Equipo equipo1,Equipo equipo2)
        {
            return (!(equipo1 == equipo2));
        }
        public string Ficha()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("{0} fundado el {1}\n", this.nombre, this.fechaCreacion);
            return sc.ToString();
        }
    }
}
