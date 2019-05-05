using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Celsius
    {
        double _cantidadGrados;

        /// <summary>
        /// Builder
        /// </summary>
        private Celsius()
        {

        }

        /// <summary>
        /// Builder with parametre
        /// </summary>
        /// <param name="cantidadGrados"></param>
        public Celsius(double cantidadGrados)
        {
            this._cantidadGrados = cantidadGrados;
        }

        /// <summary>
        /// Getter of cantidadGrados
        /// </summary>
        /// <returns>cantidad</returns>
        public double GetCantidadGrados()
        {
            return this._cantidadGrados;
        }

        /// <summary>
        /// Overload explicit of operator Fahrenheit
        /// </summary>
        /// <param name="c">Celsius</param>
        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit auxTemp = new Fahrenheit(((c._cantidadGrados * 9) / 5) + 32);
            return auxTemp;
        }

        /// <summary>
        /// Overload explicit of operator Kelvin
        /// </summary>
        /// <param name="c">Kelvin </param>
        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin auxTemp = new Kelvin(c._cantidadGrados + 273.15);
            return auxTemp;
        }

        /// <summary>
        /// Overload implicit of operator Celius
        /// </summary>
        /// <param name="grados"></param>
        public static implicit operator Celsius(double grados)
        {
            Celsius auxTemp = new Celsius(grados);
            return auxTemp;
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="temp1">temperatura 1 celsius</param>
        /// <param name="temp2">temperatura 2 fahrenheit</param>
        /// <returns>true if they are != and false if they are ==</returns>
        public static bool operator !=(Celsius temp1,Fahrenheit temp2)
        {
            bool retorno = false;
            if(temp1.GetCantidadGrados()!=((Celsius)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator ==
        /// </summary>
        /// <param name="temp1">temperatura 1 celsius</param>
        /// <param name="temp2">temperatura 2 fahrenheit</param>
        /// <returns>true if they are == and false if they are !=</returns>
        public static bool operator ==(Celsius temp1, Fahrenheit temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() == ((Celsius)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="temp1">temperatura 1 celsius</param>
        /// <param name="temp2">temperatura 2 kelvin</param>
        /// <returns>true if they are != and false if they are ==</returns>
        public static bool operator !=(Celsius temp1, Kelvin temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() != ((Celsius)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator ==
        /// </summary>
        /// <param name="temp1">temperatura 1 celsius</param>
        /// <param name="temp2">temperatura 2 kelvin</param>
        /// <returns>true if they are == and false if they are !=</returns>
        public static bool operator ==(Celsius temp1, Kelvin temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() == ((Celsius)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="temp1">fahrenheit</param>
        /// <param name="temp2">fahrenheit</param>
        /// <returns>true if they are != and false if they are ==</returns>
        public static bool operator != (Celsius temp1, Celsius temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() != temp2.GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator ==
        /// </summary>
        /// <param name="temp1">fahrenheit</param>
        /// <param name="temp2">fahrenheit</param>
        /// <returns>true if they are == and false if they are !=</returns>
        public static bool operator ==(Celsius temp1, Celsius temp2)
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
        /// <param name="temp1">celsius grades</param>
        /// <param name="temp2">fahranheit grades</param>
        /// <returns>Celsious with cantidadGrados= temp1 plus temp2</returns>
        public static Celsius operator +(Celsius temp1, Fahrenheit temp2)
        {
            Celsius auxTemp = new Celsius(temp1.GetCantidadGrados() + ((Celsius)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator +
        /// </summary>
        /// <param name="temp1">celsius grades</param>
        /// <param name="temp2">kelvin grades</param>
        /// <returns>Celsious with cantidadGrados= temp1 plus temp2</returns>
        public static Celsius operator +(Celsius temp1, Kelvin temp2)
        {
            Celsius auxTemp = new Celsius(temp1.GetCantidadGrados() + ((Celsius)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator -
        /// </summary>
        /// <param name="temp1">celsius grades</param>
        /// <param name="temp2">fahranheit grades</param>
        /// <returns>Celsious with cantidadGrados= temp1 less temp2</returns>
        public static Celsius operator -(Celsius temp1, Fahrenheit temp2)
        {
            Celsius auxTemp = new Celsius(temp1.GetCantidadGrados() - ((Celsius)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator -
        /// </summary>
        /// <param name="temp1">celsius grades</param>
        /// <param name="temp2">kelvin grades</param>
        /// <returns>Celsious with cantidadGrados= temp1 less temp2</returns>
        public static Celsius operator -(Celsius temp1, Kelvin temp2)
        {
            Celsius auxTemp = new Celsius(temp1.GetCantidadGrados() - ((Celsius)temp2).GetCantidadGrados());
            return auxTemp;
        }
    }
}
