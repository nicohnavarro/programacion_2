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
    public partial class FormLlamador : Form
    {
        bool selectOrigen = false;
        bool selectDestino = false;
        static Centralita central;

        public FormLlamador()
        {
            InitializeComponent();
        }
        public FormLlamador(Centralita centralita):this()
        {
            centralita = new Centralita("Nicolas");
            central = centralita;
        }
        public Centralita DevolverAFormMenu { get { return central; } }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(selectOrigen)
            {
               txtBoxNroOrigen.Text += btn.Text;
            }
            else if (selectDestino)
            {
                txtBoxNroDestino.Text += btn.Text;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxNroDestino.Text = "";
            txtBoxNroOrigen.Text = "";
        }

        private void txtBoxNroOrigen_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxNroOrigen.Text = "";
            selectOrigen = true;
            selectDestino = false;
            if (txtBoxNroDestino.Text[0] == '#')
                cmbFranja.Enabled = true;
            else
                cmbFranja.Enabled = false;
        }

        private void txtBoxNroDestino_MouseClick(object sender, MouseEventArgs e)
        {
            cmbFranja.Enabled = false;
            txtBoxNroDestino.Text = "";
            selectDestino = true;
            selectOrigen = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float duracion;
            float costoL;

            Random aleatorio = new Random();
            duracion = aleatorio.Next(1,51);
            costoL = aleatorio.Next(0,6);
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            if (cmbFranja.Enabled)
            {
                try
                {
                    Provincial llamadaP = new Provincial(txtBoxNroOrigen.Text, franjas, duracion, txtBoxNroDestino.Text);
                    central += llamadaP;
                    MessageBox.Show(llamadaP.ToString());
                }
                catch(CentralitaException centralitaE)
                {
                    MessageBox.Show(centralitaE.Message, "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Local llamadaL = new Local(txtBoxNroOrigen.Text, duracion, txtBoxNroDestino.Text, costoL);
                    central += llamadaL;
                    MessageBox.Show(llamadaL.ToString());
                }
                catch(CentralitaException centralitaE)
                {
                    MessageBox.Show(centralitaE.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
