using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Estante
    {
        Producto[] _productos;
        int _ubicacionEstante;

        /// <summary>
        /// Private Builder
        /// </summary>
        /// <param name="capacidad">capacidad</param>
        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }

        /// <summary>
        /// Builder with parametres
        /// </summary>
        /// <param name="capacidad">int capacidad</param>
        /// <param name="ubicacion">int ubicacion</param>
        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
            
        }

        /// <summary>
        /// Getter of product
        /// </summary>
        /// <returns>Array of product</returns>
        public Producto[] GetProductos()
        {
            return this._productos;
        }

        /// <summary>
        /// Show Estante with all product
        /// </summary>
        /// <param name="e">estante</param>
        /// <returns>string with all information</returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder infoEstante = new StringBuilder();
            string returnInfo;
            infoEstante.AppendFormat("Estante {0}\n", e._ubicacionEstante);
            foreach(Producto producto in e.GetProductos())
            {
                if(!(Object.ReferenceEquals(producto,null)))
                {
                    infoEstante.AppendLine(Producto.MostrarProducto(producto));
                }
            }
            returnInfo = infoEstante.ToString();
            return returnInfo;
        }

        /// <summary>
        /// Overload of operator ==
        /// </summary>
        /// <param name="e">estante</param>
        /// <param name="p">producto</param>
        /// <returns>true if e contains p or false if not or is null</returns>
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto producto in e.GetProductos())
            {
                if (!(Object.ReferenceEquals(producto, null)) && producto == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Overload of operator !=
        /// </summary>
        /// <param name="e">estante</param>
        /// <param name="p">producto</param>
        /// <returns>true if e not include p or false if e contains p</returns>
        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = !(e == p);
            return retorno;
        }

        /// <summary>
        /// Overload operator +
        /// </summary>
        /// <param name="e">estante</param>
        /// <param name="p">producto</param>
        /// <returns>true if add product at estante of false if not</returns>
        public static bool operator +(Estante e,Producto p)
        {
            bool retorno = false;
            bool flag = false;
            int cantidad=0;
            foreach (Producto producto in e.GetProductos())
            {
                if (!(Object.ReferenceEquals(producto, null)))
                {
                    cantidad++;
                    Console.WriteLine(cantidad);
                    if(producto==p)
                    {
                        Console.WriteLine("Error este producto ya existe en el estante");
                        flag = true;
                    }
                }
            }
            if(cantidad>=0 && cantidad<e.GetProductos().Length && !flag)
            {
                retorno = true;
                e.GetProductos()[cantidad] = p;
            }
            else if(cantidad==e.GetProductos().Length)
            {
                retorno = false;
                Console.WriteLine("Error no hay mas espacio");
            }
            return retorno;
        }

        
    }
}
