using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace VistaForm
{
    public partial class FormMenu : Form
    {
        public Centralita centralita;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            FormLlamador formLlamador = new FormLlamador(this.centralita);
            if (formLlamador.ShowDialog()== DialogResult.OK)
            {
                centralita = formLlamador.DevolverAFormMenu;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            if(!centralita.Equals(null))
            {
                MessageBox.Show(centralita.ToString());
            }
            else
            {
                MessageBox.Show("No hay llamadas");
            }
        }
    }
}
