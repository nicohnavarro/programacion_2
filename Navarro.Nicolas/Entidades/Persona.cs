using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public virtual string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendFormat("Apellido: {0}\n", this.Apellido);
            informacion.AppendFormat("Nombre: {0}\n", this.Nombre);
            informacion.AppendFormat("Edad: {0}\n", Edad);
            informacion.AppendFormat("DNI: {0}\n", Dni);

            return informacion.ToString();
        }

        public Persona(string nombre, string apellido,int edad,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public abstract bool ValidarAptitud();
    }
}
