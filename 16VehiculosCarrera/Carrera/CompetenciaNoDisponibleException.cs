using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class CompetenciaNoDisponibleException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get {return this.nombreClase; } }
        public string NombreMetodo { get {return this.nombreMetodo; } }

        public CompetenciaNoDisponibleException(string mensaje, string nombre, string metodo) : base(mensaje)
        {
            this.nombreClase = nombre;
            this.nombreMetodo = metodo;
        }
        public CompetenciaNoDisponibleException(string mensaje,string nombre,string metodo,Exception innerException):base(mensaje,innerException)
        {
            this.nombreClase = nombre;
            this.nombreMetodo = metodo;
        }
        public override string ToString()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("Excepcion en el metodo {0} de la clase {1}\n", NombreMetodo, NombreClase);
            sc.AppendFormat("Mensaje de la ex {0}\n", this.Message);
            if(!(this.InnerException is null))
                sc.AppendFormat("Inner {0}\n{1}\n\n",this.InnerException.Message,this.InnerException.ToString());

            return sc.ToString();
        }
    }
}
