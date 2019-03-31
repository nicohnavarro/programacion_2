using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Fahrenheit
    {
        double _cantidadGrados;
        
        /// <summary>
        /// Builder 
        /// </summary>
        private Fahrenheit()
        {
        }

        /// <summary>
        /// Builder with parametre
        /// </summary>
        /// <param name="cantidadGrados"></param>
        public Fahrenheit(double cantidadGrados)
        {
            this._cantidadGrados = cantidadGrados;
        }

        /// <summary>
        /// Getter of cantidad
        /// </summary>
        /// <returns>cantidad</returns>
        public double GetCantidadGrados()
        {
            return this._cantidadGrados;
        }

        /// <summary>
        /// Overload explicit of operator Celsius
        /// </summary>
        /// <param name="f">fahrenheit grades</param>
        public static explicit operator Celsius (Fahrenheit f)
        {
            Celsius auxTemp = new Celsius(((f.GetCantidadGrados()-32)*5)/9);
            return auxTemp;
        }

        /// <summary>
        /// Overload explicit of operator Kelvin
        /// </summary>
        /// <param name="f">fahrenheit grades</param>
        public static explicit operator Kelvin (Fahrenheit f)
        {
            Kelvin auxTemp = new Kelvin(((f.GetCantidadGrados() + 459.67) * 5) / 9);
            return auxTemp;
        }

        /// <summary>
        /// Overload implicit of operator Fahrenheit
        /// </summary>
        /// <param name="grados"></param>
        public static implicit operator Fahrenheit(double grados)
        {
            Fahrenheit auxTemp = new Fahrenheit(grados);
            return auxTemp;
        }

        /// <summary>
        /// Overload operador !=
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>true if they are != and false if they are ==</returns>
        public static bool operator !=(Fahrenheit temp1,Celsius temp2)
        {
            bool retorno = false;

            if(temp1.GetCantidadGrados()!=((Fahrenheit)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operador ==
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>true if they are == and false if they are !=</returns>
        public static bool operator ==(Fahrenheit temp1, Celsius temp2)
        {
            bool retorno = false;

            if (temp1.GetCantidadGrados() == ((Fahrenheit)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operador !=
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>true if they are != and false if they are ==</returns>
        public static bool operator !=(Fahrenheit temp1, Kelvin temp2)
        {
            bool retorno = false;

            if (temp1.GetCantidadGrados() != ((Fahrenheit)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operador ==
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>true if they are == and false if they are !=</returns>
        public static bool operator ==(Fahrenheit temp1, Kelvin temp2)
        {
            bool retorno = false;

            if (temp1.GetCantidadGrados() == ((Fahrenheit)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator !=
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>true if they are != and false if they are ==</returns>
        public static bool operator !=(Fahrenheit temp1, Fahrenheit temp2)
        {
            bool retorno = false;

            if(temp1.GetCantidadGrados()!=temp2.GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator ==
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>true if they are == and false if they are !=</returns>
        public static bool operator ==(Fahrenheit temp1, Fahrenheit temp2)
        {
            bool retorno = false;

            if (temp1.GetCantidadGrados() == temp2.GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator +
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>temperatura1 + temperatura2</returns>
        public static Fahrenheit operator +(Fahrenheit temp1, Celsius temp2)
        {
            Fahrenheit auxTemp = new Fahrenheit(temp1.GetCantidadGrados() + ((Fahrenheit)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator -
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>temperatura1 - temperatura2</returns>
        public static Fahrenheit operator -(Fahrenheit temp1, Celsius temp2)
        {
            Fahrenheit auxTemp = new Fahrenheit(temp1.GetCantidadGrados() - ((Fahrenheit)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator +
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>temperatura1 + temperatura2</returns>
        public static Fahrenheit operator +(Fahrenheit temp1, Kelvin temp2)
        {
            Fahrenheit auxTemp = new Fahrenheit(temp1.GetCantidadGrados() + ((Fahrenheit)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator -
        /// </summary>
        /// <param name="temp1">temperatura 1</param>
        /// <param name="temp2">temperatura 2</param>
        /// <returns>temperatura1 - temperatura2</returns>
        public static Fahrenheit operator -(Fahrenheit temp1, Kelvin temp2)
        {
            Fahrenheit auxTemp = new Fahrenheit(temp1.GetCantidadGrados() - ((Fahrenheit)temp2).GetCantidadGrados());
            return auxTemp;
        }
    }
}
