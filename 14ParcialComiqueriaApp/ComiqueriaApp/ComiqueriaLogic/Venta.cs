using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        static int porcentajelva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha { get { return this.fecha; } }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double resultado;
            double precioIva=(porcentajelva* precioUnidad) / 100;
            resultado = (precioIva+precioUnidad) * cantidad;
            return resultado;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("{0}-{1}-{2,10:#,###.00\n}", this.fecha, this.producto.Descripcion, this.precioFinal);
            return sc.ToString();
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = new DateTime();
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio,cantidad);
        }

        static Venta()
        {
            porcentajelva = 21;
        }

        internal Venta(Producto p,int cantidad)
        {
            this.producto = p;
            Vender(cantidad);

        }

    }
}
