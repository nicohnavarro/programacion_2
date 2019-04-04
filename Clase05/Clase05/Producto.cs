using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Producto
    {
        string _codigoDeBarra;
        string _marca;
        float _precio;

        /// <summary>
        /// Builder with parametres
        /// </summary>
        /// <param name="marca">marca of product</param>
        /// <param name="codigo">code of product</param>
        /// <param name="precio">price of product</param>
        public Producto(string marca,string codigo,float precio)
        {
            this._marca = marca;
            this._precio = precio;
            this._codigoDeBarra = codigo;
        }

        /// <summary>
        /// Overload explicit of operator string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            string retorno;
            retorno = (p._codigoDeBarra).ToString();
            return retorno;
        }

        /// <summary>
        /// Getter of marca
        /// </summary>
        /// <returns>marca of product</returns>
        public string GetMarca()
        {
            return this._marca;
        }

        /// <summary>
        /// Getter of price
        /// </summary>
        /// <returns>price of producto</returns>
        public float GetPrecio()
        {
            return this._precio;
        }
        
        /// <summary>
        /// Show the Product with attributes
        /// </summary>
        /// <param name="p">object Producto</param>
        /// <returns>producto with marca,price and code</returns>
        public static string MostrarProducto(Producto p)
        {
            StringBuilder infoProducto = new StringBuilder();
            string showProduct;

            infoProducto.AppendFormat("Producto : \nMarca:{0}\nPrecio: ${1}\nCodigo de Barra: {2}\n", p.GetMarca(), p.GetPrecio(), p._codigoDeBarra);
            showProduct = infoProducto.ToString();
            return showProduct;
        }

        /// <summary>
        /// Overload of operator !=
        /// </summary>
        /// <param name="p">product</param>
        /// <param name="marca">string marca</param>
        /// <returns>true if they are != or false if not</returns>
        public static bool operator !=(Producto p,string marca)
        {
            bool retorno = false;
            if(p.GetMarca()!=marca)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator ==
        /// </summary>
        /// <param name="p">product</param>
        /// <param name="marca">string marca</param>
        /// <returns>true if they are == or false if not</returns>
        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if (p.GetMarca() == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator !=
        /// </summary>
        /// <param name="p1">Product one</param>
        /// <param name="p2">Product two</param>
        /// <returns>true if they are != or false if not</returns>
        public static bool operator !=(Producto p1,Producto p2)
        {
            bool retorno = false;
            if(p1.GetMarca()!=p2.GetMarca() && p1._codigoDeBarra!=p2._codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator ==
        /// </summary>
        /// <param name="p1">Product one</param>
        /// <param name="p2">Product two</param>
        /// <returns>true if they are == or false if not</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.GetMarca() == p2.GetMarca() && (string)p1 == (string)p2)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
