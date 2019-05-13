using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                Producto retorno = null;
                bool flag = false;
                foreach (Producto productoAux in productos)
                {
                    if ((Guid)productoAux == codigo)
                    {
                        retorno = productoAux;
                        flag = true;
                    }
                }
                return flag ? retorno : null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> listaPro = new Dictionary<Guid, string>();
            foreach (Producto productoAux in this.productos)
            {
                listaPro.Add((Guid)productoAux, productoAux.Descripcion);
            }
            return listaPro;
        }

        public string ListarVentas()
        {
            StringBuilder sc = new StringBuilder();
            this.ventas.Sort(OrdenarVentas);
            foreach(Venta ventasAux in this.ventas)
            {
                sc.AppendFormat("{0}\n", ventasAux.ObtenerDescripcionBreve());
            }
            return sc.ToString();
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = false;
            foreach (Producto productoAux in comiqueria.productos)
            {
                if (productoAux.Descripcion == producto.Descripcion)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta ventaNueva = new Venta(producto, cantidad);
            this.ventas.Add(ventaNueva);
        }

        private int OrdenarVentas(Venta v1, Venta v2)
        {
            int retorno = 0;
            if (v1.Fecha < v2.Fecha)
            {
                retorno = 1;
            }
            else if(v1.Fecha> v2.Fecha)
            {
                retorno = -1;
            }
            return retorno;
        }
    }
}
