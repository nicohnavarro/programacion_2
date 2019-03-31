using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
         int _cantidadSumas;


        /// <summary>
        /// OverLoad of operador Conversion 
        /// </summary>
        /// <param name="s">Cantidad de Sumas</param>
        public static explicit operator int (Sumador s)
        {
            return s._cantidadSumas;
        } 

        /// <summary>
        /// OverLoad of operador | compare between two Sumador
        /// </summary>
        /// <param name="s1">First Sumador</param>
        /// <param name="s2">Second Sumador</param>
        /// <returns></returns>
        public static bool operator | (Sumador s1,Sumador s2)
        {
            bool retorno = false;
            if(s1._cantidadSumas==s2._cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// OverLoad of operator + between two Sumador
        /// </summary>
        /// <param name="s1">First Sumador</param>
        /// <param name="s2">Second Sumador</param>
        /// <returns>Sum of two Sumador</returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1._cantidadSumas+s2._cantidadSumas;
        }

        /// <summary>
        /// Builder The value of cantidadSumas is 0
        /// </summary>
        public Sumador():this(0)
        {

        }

        /// <summary>
        /// Builder with parametres 
        /// </summary>
        /// <param name="cantidadSumas">cantidadSumas</param>
        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Sum between two number 
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>sum of First number plus Second number</returns>
        public long Sumar(long a,long b)
        {
            this._cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Sum between two strings
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <returns>Concatenation of First string and Second string</returns>
        public string Sumar(string a, string b)
        {
            string retorno=string.Concat(a,b);
            this._cantidadSumas++;
            return retorno;
        }

    }
}
