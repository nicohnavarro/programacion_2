using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        double _cantidad;
        float _cotizRespectoDolar;

        /// <summary>
        /// Builder
        /// </summary>
        private Euro()
        {
            this._cotizRespectoDolar = 1.16f;
        }

        /// <summary>
        /// Builder with one parametre
        /// </summary>
        /// <param name="cantidad">cantidad</param>
        public Euro(double cantidad)
        {
            this._cantidad = cantidad;
            this._cotizRespectoDolar = 1.16f;
        }

        /// <summary>
        /// Builder with two parametres
        /// </summary>
        /// <param name="cantidad">cantidad</param>
        /// <param name="cotizacion">cotizacion</param>
        public Euro(double cantidad, float cotizacion):this(cantidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }

        /// <summary>
        /// OverLoad operator explicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Dolar(Euro e)
        {
            Dolar auxDolar = new Dolar(e.GetCantidad() * e.GetCotizacion());
            return auxDolar;
        }

        /// <summary>
        /// OverLoad operator explicit conversion
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Euro e)
        {
            Pesos auxPesos = new Pesos(e.GetCantidad() * e.GetCotizacion() * 38.33);
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
        public static implicit operator Euro(double e)
        {
            Euro euro = new Euro(e);
            return euro.GetCantidad();
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="d">dolar</param>
        /// <param name="e">euro</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Euro e, Dolar d)
        {
            bool retorno = false;
            if(e.GetCantidad()!=(d.GetCantidad()/e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="p">pesos</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Euro e, Pesos p)
        {
            bool retorno = false;
            if(e.GetCantidad()!=(p.GetCantidad()*p.GetCotizacion()*e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of != operator
        /// </summary>
        /// <param name="e1">euro1</param>
        /// <param name=e2">euro2</param>
        /// <returns>true if != or false if ==</returns>
        public static bool operator !=(Euro e1,Euro e2)
        {
            bool retorno = false;
            if(e1.GetCantidad()!=e2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad - operator 
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="d">dollar</param>
        /// <returns>euro (euro less dollar)</returns>
        public static Euro operator -(Euro e,Dolar d)
        {
            Euro auxEuro = new Euro();
            auxEuro._cantidad = e._cantidad - (d.GetCantidad() * e.GetCotizacion());
            return auxEuro;
        }

        /// <summary>
        /// OverLoad - operator
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="p">peso</param>
        /// <returns>euro (euro less peso)</returns>
        public static Euro operator -(Euro e, Pesos p)
        {
            Euro auxEuro = new Euro();
            auxEuro._cantidad = e._cantidad - (p.GetCantidad() * p.GetCotizacion()*e.GetCotizacion());
            return auxEuro;
        }

        /// <summary>
        /// OverLoad + operator
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="d">dollar</param>
        /// <returns>euro (euro plus dollar)</returns>
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro auxEuro = new Euro();
            auxEuro._cantidad = e._cantidad + (d.GetCantidad() * e.GetCotizacion());
            return auxEuro;
        }

        /// <summary>
        /// OverLoad + operator
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="p">peso</param>
        /// <returns>euro (euro plus peso)</returns>
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro auxEuro = new Euro();
            auxEuro._cantidad = e._cantidad + (p.GetCantidad() * p.GetCotizacion() * e.GetCotizacion());
            return auxEuro;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="d">dolar</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if (e.GetCantidad() == (d.GetCantidad() / e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad != operator
        /// </summary>
        /// <param name="e">euro</param>
        /// <param name="p">pesos</param>
        /// <returns>true if == or false if !=</returns>
        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;
            if (e.GetCantidad() == (p.GetCantidad() * p.GetCotizacion() * e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of != operator
        /// </summary>
        /// <param name="e1">euro1</param>
        /// <param name=e2">euro2</param>
        /// <returns>true if == or false if 1=</returns>
        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
