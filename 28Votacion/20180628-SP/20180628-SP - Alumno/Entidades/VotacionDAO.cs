using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Excepciones;
namespace Entidades
{
    public class VotacionDAO : IArchivos<Votacion>
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        public VotacionDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(@"Data Source= .\SQLEXPRESS; Initial Catalog=votacion-sp-2018; Integrated Security= True");
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public bool Guardar(string rutaArchivo, Votacion datos)
        {
            bool retorno = false;
            string consulta = string.Format("INSERT INTO {0} (nombreLey,afirmativos,abstenciones,negativos,nombreAlumno) " +
                "VALUES ('{1}','{2}','{3}','{4}','Navarro Nicolas')",rutaArchivo, 
                datos.NombreLey, datos.ContadorAfirmativo, datos.ContadorAbstencion, datos.ContadorNegativo);
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al Guardar SQL...", e);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            return retorno;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
