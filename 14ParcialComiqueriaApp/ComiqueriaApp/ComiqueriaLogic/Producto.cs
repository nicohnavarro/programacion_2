using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion { get { return this.descripcion; } }
        public double Precio { get { return this.precio; } }
        public int Stock
        {
            get { return this.stock; }
            set
            {
                if(value>=0)
                {
                    this.stock = value;
                }
            }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public override string ToString()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("\nDescripcion: {0}\n",this.Descripcion);
            sc.AppendFormat("Codigo: {0}\n",(Guid)this);
            sc.AppendFormat("Precio: {0}\n", this.Precio);
            sc.AppendFormat("Stock: {0}\n", this.Stock);
            return sc.ToString();
        }
    }
}
