using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Kelvin
    {
        double _cantidadGrados;

        /// <summary>
        /// Builder
        /// </summary>
        private Kelvin()
        {

        }

        /// <summary>
        /// Builder with parametre
        /// </summary>
        /// <param name="cantidadGrados"></param>
        public Kelvin(double cantidadGrados)
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
        public static explicit operator Fahrenheit(Kelvin c)
        {
            Fahrenheit auxTemp = new Fahrenheit((((c._cantidadGrados - 273.15) * 9) / 5)+32);
            return auxTemp;
        }

        /// <summary>
        /// Overload explicit of operator Celsius
        /// </summary>
        /// <param name="c">Celsius </param>
        public static explicit operator Celsius(Kelvin c)
        {
            Celsius auxTemp = new Celsius(c._cantidadGrados - 273.15);
            return auxTemp;
        }

        /// <summary>
        /// Overload implicit of operator Kelvin
        /// </summary>
        /// <param name="grados"></param>
        public static implicit operator Kelvin(double grados)
        {
            Kelvin auxTemp = new Kelvin(grados);
            return auxTemp;
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">fahrenheit</param>
        /// <returns>true if are != false if are ==</returns>
        public static bool operator !=(Kelvin temp1, Fahrenheit temp2)
        {
            bool retorno = false;
            if(temp1.GetCantidadGrados()!= ((Kelvin)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">celsius</param>
        /// <returns>true if are != false if are ==</returns>
        public static bool operator !=(Kelvin temp1, Celsius temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() != ((Kelvin)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator ==
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">fahrenheit</param>
        /// <returns>true if are == false if are !=</returns>
        public static bool operator ==(Kelvin temp1, Fahrenheit temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() == ((Kelvin)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator ==
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">celsius</param>
        /// <returns>true if are == false if are !=</returns>
        public static bool operator ==(Kelvin temp1, Celsius temp2)
        {
            bool retorno = false;
            if (temp1.GetCantidadGrados() == ((Kelvin)temp2).GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">kelvin</param>
        /// <returns>true if are != false if are ==</returns>
        public static bool operator !=(Kelvin temp1, Kelvin temp2)
        {
            bool retorno = false;
            if(temp1.GetCantidadGrados()!=temp2.GetCantidadGrados())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload operator ==
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">kelvin</param>
        /// <returns>true if are == false if are !=</returns>
        public static bool operator ==(Kelvin temp1, Kelvin temp2)
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
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">fahranheit</param>
        /// <returns>kelvin with cantidadGrados = temp1 plus temp2</returns>
        public static Kelvin operator + (Kelvin temp1,Fahrenheit temp2)
        {
            Kelvin auxTemp = new Kelvin(temp1.GetCantidadGrados() + ((Kelvin)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator -
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">fahranheit</param>
        /// <returns>kelvin with cantidadGrados = temp1 less temp2</returns>
        public static Kelvin operator -(Kelvin temp1, Fahrenheit temp2)
        {
            Kelvin auxTemp = new Kelvin(temp1.GetCantidadGrados() - ((Kelvin)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator +
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">celsius</param>
        /// <returns>kelvin with cantidadGrados = temp1 plus temp2</returns>
        public static Kelvin operator +(Kelvin temp1, Celsius temp2)
        {
            Kelvin auxTemp = new Kelvin(temp1.GetCantidadGrados() + ((Kelvin)temp2).GetCantidadGrados());
            return auxTemp;
        }

        /// <summary>
        /// Overload operator -
        /// </summary>
        /// <param name="temp1">kelvin</param>
        /// <param name="temp2">celsius</param>
        /// <returns>kelvin with cantidadGrados = temp1 less temp2</returns>
        public static Kelvin operator -(Kelvin temp1, Celsius temp2)
        {
            Kelvin auxTemp = new Kelvin(temp1.GetCantidadGrados() - ((Kelvin)temp2).GetCantidadGrados());
            return auxTemp;
        }
    }
}
