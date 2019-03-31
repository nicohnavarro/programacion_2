using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        double _cantidad;
        float _cotizRespectoDolar;

        /// <summary>
        /// Builder
        /// </summary>
        private Dolar()
        {
            this._cotizRespectoDolar = 1;
        }

        /// <summary>
        /// Builder with one parametre
        /// </summary>
        /// <param name="cantidad">cantidad</param>
        public Dolar(double cantidad)
        {
            this._cantidad = cantidad;
        }

        /// <summary>
        /// Builder with two parametres
        /// </summary>
        /// <param name="cantidad">cantidad</param>
        /// <param name="cotizacion">cotizacion</param>
        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }

        /// <summary>
        /// OverLoad operator explicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {
            Euro auxEuro = new Euro(d._cantidad/1.16);
           
            return auxEuro;
        }

        /// <summary>
        /// OverLoad operator explicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Dolar d)
        {
            Pesos auxPesos = new Pesos(d._cantidad * 38.33);
            return auxPesos;
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
        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar._cantidad;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="d">dolar</param>
        /// <param name="e">euro</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            bool retorno = false;
            if(d.GetCantidad()!=(e.GetCantidad()*e.GetCotizacion()))
            {
                retorno = true;        
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="d">dolar</param>
        /// <param name="p">pesos</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Dolar d, Pesos p)
        {
            bool retorno=false;
            if(d.GetCantidad()!=(p.GetCantidad()/p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of != operator
        /// </summary>
        /// <param name="d1">dolar1</param>
        /// <param name="d2">dolar2</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if(d1.GetCantidad()!=d2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad - operator 
        /// </summary>
        /// <param name="d">dollar</param>
        /// <param name="e">euro</param>
        /// <returns>dollar (dollar less euro)</returns>
        public static Dolar operator -(Dolar d,Euro e)
        {
            Dolar auxDolar = new Dolar();
            auxDolar._cantidad = d.GetCantidad() - (e.GetCantidad() * e.GetCotizacion());
            return auxDolar;
        }

        /// <summary>
        /// OverLoad - operator
        /// </summary>
        /// <param name="d">dollar</param>
        /// <param name="p">peso</param>
        /// <returns>dollar (dollar less peso)</returns>
        public static Dolar operator -(Dolar d,Pesos p)
        {
            Dolar auxDolar = new Dolar();
            auxDolar._cantidad = d.GetCantidad() - (p.GetCantidad() / p.GetCotizacion());
            return auxDolar;
        }

        /// <summary>
        /// OverLoad + operator
        /// </summary>
        /// <param name="d">dollar</param>
        /// <param name="e">euro</param>
        /// <returns>dollar (dollar plus euro)</returns>
        public static Dolar operator +(Dolar d,Euro e)
        {
            Dolar auxDolar = new Dolar();
            auxDolar._cantidad = d.GetCantidad() + (e.GetCantidad() * e.GetCotizacion());
            return auxDolar;
        }

        /// <summary>
        /// OverLoad + operator
        /// </summary>
        /// <param name="d">dollar</param>
        /// <param name="p">peso</param>
        /// <returns>dollar (dollar plus peso)</returns>
        public static Dolar operator +(Dolar d,Pesos p)
        {
            Dolar auxDolar = new Dolar();
            auxDolar._cantidad = d.GetCantidad() + (p.GetCantidad() / p.GetCotizacion());
            return auxDolar;
        }

        /// <summary>
        /// OverLoad == operator
        /// </summary>
        /// <param name="d">dolar</param>
        /// <param name="e">euro</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            if (d.GetCantidad() == (e.GetCantidad() * e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad == operator
        /// </summary>
        /// <param name="d">dolar</param>
        /// <param name="p">pesos</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;
            if (d.GetCantidad() == (p.GetCantidad() / p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of == operator
        /// </summary>
        /// <param name="d1">dolar1</param>
        /// <param name="d2">dolar2</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
