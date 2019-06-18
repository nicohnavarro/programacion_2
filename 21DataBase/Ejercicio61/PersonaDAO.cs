using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;
        //string connection = "Data Source=ALPHA\\SQLEXPRESS; Initial Catalog=Persona; Integrated Security=True";

        static PersonaDAO()
        {
            string connectionStr = @"Data Source=ALPHA\SQLEXPRESS; Initial Catalog=Persona; Integrated Security= True";
            try
            {
                
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static bool Guardar(string nombre,string apellido)
        {
            bool retorno = false;

            try
            {
                string consulta = String.Format("INSERT INTO Persona (Nombre, Apellido) VALUES ('{0}','{1}')", nombre, apellido);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return retorno;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            Persona persona;

            string consult = String.Format("SELECT * FROM Persona ORDER BY ID DESC");

            try
            {
                comando.CommandText = consult;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id = int.Parse(oDr["ID"].ToString());
                    string nombre = oDr["Nombre"].ToString();
                    string apellido = oDr["Apellido"].ToString();
                    persona = new Persona(id, nombre, apellido);
                    personas.Add(persona);
                }
            }
            catch (Exception e)
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
            return personas;
        }
        public static Persona LeerByID(int id)
        {
            Persona persona=null;
            string consult = String.Format("SELECT * FROM Persona WHERE ID={0}", id);

            try
            {
                comando.CommandText = consult;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    int idAux = int.Parse(oDr["ID"].ToString());
                    string nombre = oDr["Nombre"].ToString();
                    string apellido = oDr["Apellido"].ToString();

                    persona = new Persona(idAux, nombre, apellido);
                }
            }
            catch (Exception e)
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
            return persona;
        }

        public static bool Modificar(Persona persona)
        {
            bool retorno = false;

            try
            {
                string consult = String.Format("UPDATE Persona SET Nombre='{0}',Apellido='{1}' WHERE ID={2}"
                        , persona.Nombre, persona.Apellido, persona.Id);
                comando.CommandText = consult;
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
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
            return retorno;
        }

        public static bool Borrar(int id)
        {
            bool retorno = false;

            try
            {
                string consult = String.Format("DELETE FROM Persona WHERE ID={0}", id);
                comando.CommandText = consult;
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
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
            return retorno;
        }
 
    }
}
