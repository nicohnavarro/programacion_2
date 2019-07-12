using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _20190711_Final
{
    public partial class FrmAerolinea : Form
    {
        private Aeropuerto<Vuelo> aeropuerto;
        private SqlCommand comando;
        private SqlConnection conexion;


        public FrmAerolinea()
        {
            InitializeComponent();
            string path = @"Data Source= .\SQLEXPRESS; Initial Catalog= final2019; Integrated Security= True";
            comando = new SqlCommand();
            conexion = new SqlConnection(path);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            this.aeropuerto = new Aeropuerto<Vuelo>();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = (int)nudHorasDeVuelo.Value;
            Vuelo vuelo = new Vuelo(horas);
            int ejeY = this.aeropuerto + vuelo;

            this.Controls.Add(vuelo);
            vuelo.Location = new Point(0, ejeY);
            
            vuelo.Despegar();
        }

        private void FrmAerolinea_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aeropuerto.FinalizarVuelos();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser = null;
            string path = string.Format("{0}\\Bitacora.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            try
            {
                writer = new XmlTextWriter(path, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Aeropuerto<Vuelo>));
                ser.Serialize(writer, this.aeropuerto);
            }

            catch (ErrorArchivoException exc)
            {
                MessageBox.Show(exc.Message + exc.InnerException.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path= string.Format("{0}\\Archivo.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            XmlTextReader reader = null;
            XmlSerializer ser = null;
            try
            {
                reader = new XmlTextReader(path);
                ser = new XmlSerializer(typeof(Aeropuerto<Vuelo>));
                this.aeropuerto = (Aeropuerto<Vuelo>)ser.Deserialize(reader);
            }
            catch (ErrorArchivoException exc)
            {
                MessageBox.Show(exc.Message + exc.InnerException.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo no elegi ese metodo", "Error", MessageBoxButtons.OK);
        }

        private void binarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo no elegi ese metodo", "Error", MessageBoxButtons.OK);
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string log;
            log = this.aeropuerto.LogAvion();
            string consulta = string.Format("INSERT INTO Bitacora (entrada,alumno) VALUES ('{0}','Navarro Nicolas')",log);
            comando.CommandText = consulta;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se Guardo", "Atencion", MessageBoxButtons.OK);
            }
            catch(ErrorArchivoException exc)
            {
                throw new ErrorArchivoException("Error 2", exc);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo no elegi ese metodo", "Error", MessageBoxButtons.OK);
        }
    }
}
