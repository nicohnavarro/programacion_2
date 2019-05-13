using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        static int porcentajelva;
        private double precioFinal;
        private Producto producto;

        public DateTime Fecha { get { return this.fecha; } }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double resultado;
            resultado = precioUnidad * cantidad;
            resultado *= porcentajelva/100;
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
            producto.Stock -= 1;
            this.fecha = new DateTime();
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio,cantidad);
        }

        static Venta()
        {
            porcentajelva = 21;
        }

        public Venta(Producto p,int cantidad)
        {
            this.producto = p;
            Vender(cantidad);

        }

    }
}
