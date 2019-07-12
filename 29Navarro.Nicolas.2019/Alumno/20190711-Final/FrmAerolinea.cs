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
using Archivos;

namespace _20190711_Final
{
    public partial class FrmAerolinea : Form
    {
        private Aeropuerto<Vuelo> aeropuerto;
        private string log;

        public object Archivo { get; private set; }

        public FrmAerolinea()
        {
            InitializeComponent();
            this.aeropuerto = new Aeropuerto<Vuelo>();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = (int)nudHorasDeVuelo.Value;
            Vuelo vuelo = new Vuelo(horas);
            int ejeY = this.aeropuerto + vuelo;
            this.log=this.aeropuerto.LogAvion(horas);
            Archivos.Sql<string>.Guardar(this.log);
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
            if(Archivos.Xml<Aeropuerto<Vuelo>>.Guardar(this.aeropuerto))
            {
                MessageBox.Show("Se guardo Xml", "Atencion", MessageBoxButtons.OK);
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.aeropuerto = Archivos.Xml<Aeropuerto<Vuelo>>.Leer();
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
            Archivos.Sql<Aeropuerto<Vuelo>>.Guardar(this.aeropuerto);
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo no elegi ese metodo", "Error", MessageBoxButtons.OK);
        }
    }
}
