using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona:Corredor
    {
        private string _nombre;

        public override void Correr()
        {
            while(true)
            {
                
                Corriendo((int)_avance.Next(0, this.VelocidadMaxima),this);
                Thread.Sleep(300);
            }

        }

        public override void Guardar(string path)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, true);
                writer.WriteLine("El Ganador es: {0}",this.ToString());
            }
            catch(Exception e)
            {
                throw new NoSeGuardoException(e);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public Persona(string nombre,short velocidadMax,Carril carril):base(velocidadMax,carril)
        {
            this._nombre = nombre;
        }

        public override string ToString()
        {
            return string.Format("{0} en el carril {1} a una velocidad maxima de {2}.\n", this._nombre, this.CarrilElegido, this.VelocidadMaxima);
        }

        public delegate void CorrenCallback(int avance, Corredor corredor);
        public event CorrenCallback Corriendo;
    }

}
