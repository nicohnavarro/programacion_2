using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        protected static Random _avance;
        protected Carril _carrilElegido;
        private short _velocidadMax;

        public Carril CarrilElegido { get { return this._carrilElegido; } }
        public short VelocidadMaxima
        {
            get
            {
                return this._velocidadMax;
            }

            set
            {
                if (value <= 10)
                    this._velocidadMax = value;

            }
        }

        static Corredor()
        {
            _avance = new Random();
        }

        protected Corredor(short velocidadMax, Carril carril)
        {
            this._carrilElegido = carril;
            this.VelocidadMaxima = velocidadMax;
        }

        public abstract void Correr();

        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }

        public enum Carril
        {
            Carril_1,
            Carril_2
        }
    }
}
