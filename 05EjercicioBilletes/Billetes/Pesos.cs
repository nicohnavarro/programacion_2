using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        double _cantidad;
        float _cotizRespectoDolar;

        /// <summary>
        /// Builder
        /// </summary>
        private Pesos()
        {
            this._cotizRespectoDolar = 38.33f;
        }

        /// <summary>
        /// Builder with one parametre
        /// </summary>
        /// <param name="cantidad">cantidad</param>
        public Pesos(double cantidad)
        {
            this._cantidad = cantidad;
            this._cotizRespectoDolar = 38.33f;
        }

        /// <summary>
        /// Builder with two parametres
        /// </summary>
        /// <param name="cantidad">cantidad</param>
        /// <param name="cotizacion">cotizacion</param>
        public Pesos(double cantidad, float cotizacion):this(cantidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }

        /// <summary>
        /// OverLoad operator explicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Dolar(Pesos p)
        {
            Dolar auxDolar = new Dolar(p.GetCantidad() / p.GetCotizacion());
            return auxDolar;
        }

        /// <summary>
        /// OverLoad operator explicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Pesos p)
        {
            Euro auxEuro = new Euro(p.GetCantidad() / p.GetCotizacion() / 1.16);
            return auxEuro;
        }

        /// <summary>
        /// Getter of cantidad
        /// </summary>
        /// <returns>cantidad</returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }

        /// <summary>
        /// Getter of cotizacion
        /// </summary>
        /// <returns>cotizacion</returns>
        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }

        /// <summary>
        /// OverLoad implicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Pesos(double e)
        {
            Pesos pesos = new Pesos(e);
            return pesos.GetCantidad();
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="d">dolar</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Pesos p, Dolar d)
        {
            bool retorno = false;
            if(p.GetCantidad()!=(d.GetCantidad()*p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="e">euro</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Pesos p, Euro e)
        {
            bool retorno = false;
            if(p.GetCantidad()!=(e.GetCantidad()*e.GetCotizacion()*p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of != operator
        /// </summary>
        /// <param name="p1">peso1</param>
        /// <param name="p2">peso2</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool retorno = false;
            if(p1.GetCantidad()!=p2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad - operator 
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="d">dollar/param>
        /// <returns>peso (peso less dollar)</returns>
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos auxPesos = new Pesos();
            auxPesos._cantidad=p.GetCantidad() - (d.GetCantidad() * p.GetCotizacion());
            return auxPesos;
        }

        /// <summary>
        /// OverLoad - operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="e">euro</param>
        /// <returns>peso (peso less euro)</returns>
        public static Pesos operator -(Pesos p,Euro e)
        {
            Pesos auxPesos = new Pesos();
            auxPesos._cantidad = p.GetCantidad() - (e.GetCantidad() * e.GetCotizacion() * p.GetCotizacion());
            return auxPesos;
        }

        /// <summary>
        /// OverLoad + operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="d">dolar</param>
        /// <returns>peso (peso plus dollar)</returns>
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos auxPesos = new Pesos();
            auxPesos._cantidad = (p.GetCantidad() + (d.GetCantidad() * p.GetCotizacion()));
            return auxPesos;
        }

        /// <summary>
        /// OverLoad + operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="e">euro</param>
        /// <returns>peso (peso plus euro)</returns>
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos auxPesos = new Pesos();
            auxPesos._cantidad = p.GetCantidad() + (e.GetCantidad() * e.GetCotizacion() * p.GetCotizacion());
            return auxPesos;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="d">dolar</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;
            if (p.GetCantidad() == (d.GetCantidad() * p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="p">peso</param>
        /// <param name="e">euro</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Pesos p, Euro e)
        {
            bool retorno = false;
            if(p.GetCantidad()==(e.GetCantidad()*e.GetCotizacion()*p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of != operator
        /// </summary>
        /// <param name="p1">peso1</param>
        /// <param name="p2">peso2</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Pesos p1,Pesos p2)
        {
            bool retorno = false;
            if(p1.GetCantidad()==p2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
