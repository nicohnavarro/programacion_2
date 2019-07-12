using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using Entidades;
using System.Data;

namespace Archivos
{
    public  static class Sql<T>
    {
        public static SqlCommand comando;
        public static SqlConnection conexion;
        public static string path;

        static Sql()
        {
            path= @"Data Source= .\SQLEXPRESS; Initial Catalog= final2019; Integrated Security= True";
            comando = new SqlCommand();
            conexion = new SqlConnection(path);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static bool Guardar(T datos)
        {
            bool retorno = false;
            string query = string.Format("INSERT INTO Bitacora (entrada,alumno) VALUES ('{0}','Navarro Nicolas')",datos);
            comando.CommandText = query;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (ErrorArchivoException exc)
            {
                throw new ErrorArchivoException("Error De Archivo", exc);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return retorno;
        }
    }
}
