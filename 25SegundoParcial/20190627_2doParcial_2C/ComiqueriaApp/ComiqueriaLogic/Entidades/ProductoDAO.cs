using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ComiqueriaLogic.Entidades
{
    public class ProductoDAO
    {
        private SqlCommand command;
        private SqlConnection connection;


        public delegate void MiDelegado(AccionesDB accionesDB);
        public static event MiDelegado MiEvento;
        /// <summary>
        /// Establecemos la conexion
        /// </summary>
        public ProductoDAO()
        {
            string connectionStr;
            connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog= Comiqueria; Integrated Security=True";

            this.connection = new SqlConnection(connectionStr);
            this.command = new SqlCommand();
            this.command.CommandType = System.Data.CommandType.Text;
            this.command.Connection = this.connection;
        }

        /// <summary>
        /// Guarda un producto nuevo
        /// </summary>
        /// <param name="p">Producto a Guardar</param>
        /// <returns>True si lo guardo - False si no</returns>
        public bool Guardar(Producto p)
        {
            string consulta;
            bool guardo = false;
            consulta = string.Format("Insert Into Productos (Descripcion,Precio,Stock) " +
                "Values ('{0}','{1}','{2}')", p.Descripcion, p.Precio, p.Stock);
            try
            {
                this.command.CommandText = consulta;
                this.connection.Open();
                this.command.ExecuteNonQuery();
                guardo = true;
            }
            catch(Exception e)
            {
                guardo = false;
                throw e;
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                    this.connection.Close();
            }
            MiEvento(AccionesDB.Insert);
            return guardo;
        }

        public bool Modificar(Producto p,double precio)
        {
            string consulta;
            bool modifico = false;
            consulta = string.Format("UPDATE Productos SET Precio='{0}' WHERE Codigo='{1}'", precio, p.Codigo);
            try
            {
                this.command.CommandText = consulta;
                this.connection.Open();
                this.command.ExecuteNonQuery();
                modifico = true;
            }
            catch(Exception e)
            {
                modifico = false;
                throw e;
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                    this.connection.Close();
            }
            MiEvento(AccionesDB.Update);
            return modifico;
        }

        public bool Eliminar(Producto p)
        {
            string consulta;
            bool elimino = false;
            consulta = string.Format("DELETE FROM Productos WHERE Codigo='{0}'", p.Codigo);
            try
            {
                this.command.CommandText = consulta;
                this.connection.Open();
                this.command.ExecuteNonQuery();
                elimino = true;
            }
            catch(Exception e)
            {
                elimino = false;
                throw e;
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                    this.connection.Close();
            }
            MiEvento(AccionesDB.Delete);
            return elimino;
        }

        public List<Producto> Leer()
        {
            List<Producto> productos=new List<Producto>();
            string consulta;
            consulta = string.Format("SELECT * FROM Productos");
            try
            {
                this.command.CommandText = consulta;
                this.connection.Open();
                SqlDataReader oDr = this.command.ExecuteReader();

                while(oDr.Read())
                {
                    int codigo = int.Parse(oDr["Codigo"].ToString());
                    string descripcion = oDr["Descripcion"].ToString();
                    double precio = double.Parse(oDr["Precio"].ToString());
                    int stock = int.Parse(oDr["Stock"].ToString());
                    Producto productoAux = new Producto(codigo, descripcion, stock, precio);
                    productos.Add(productoAux);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                    this.connection.Close();
            }

            return productos;
        }

    }
}
