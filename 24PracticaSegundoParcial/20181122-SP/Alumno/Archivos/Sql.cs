using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql: IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            string connectionStr = @"Data Source= .\SQLEXPRESS; Initial Catalog=patentes-sp-2018; Integrated Security= True";
            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            foreach(Patente patenteAux in datos)
            {
                try
                {
                    string consulta = String.Format("Insert into {0} (patente, tipo) Values ('{1}','{2}') ", tabla, patenteAux.CodigoPatente, patenteAux.TipoCodigo);
                    comando.CommandText = consulta;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    if(conexion.State==ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
            
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            Patente patente;
            string consulta = String.Format("Select * from {0}",tabla);
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while(oDr.Read())
                {
                    string codPatente = oDr["patente"].ToString();
                    Enum.TryParse(oDr["tipo"].ToString(), out Patente.Tipo tipo);
                    patente = new Patente(codPatente, tipo);
                    datos.Enqueue(patente);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if(conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
