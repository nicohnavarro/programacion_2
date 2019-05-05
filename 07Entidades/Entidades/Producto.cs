using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EMarcaProducto
    {
        Manaos,
        Pitusas,
        Naranjû,
        Diversion,
        Swift,
        Favorita
    }

    public enum ETipoProducto
    {
        Galletita,
        Gaseosa,
        Jugo,
        Harina,
        Todos,
    }

    public abstract class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public float CalcularCostoDeProducto
        {
            get
            {
                return this._precio;
            }
        }

        public EMarcaProducto Marca
        {
            get
            {
                return this._marca;
            }
        }

        public float Precio
        {
            get
            {
                return this._precio;
            }
        }

        public string Consumir()
        {
            return "";
        }

        public override bool Equals(Object obj)
        {
            return false;
        }

        public static explicit operator int(Producto p)
        {
            return 0;
        }

        public static implicit operator string(Producto p)
        {
            return "";
        }
        
        private virtual string  MostrarProducto(Producto p)
        {
            return "";
        }

        public static bool operator !=(Producto productoUno, EMarcaProducto marca)
        {

        }
            


    }
}
