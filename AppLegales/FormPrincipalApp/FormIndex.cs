using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipalApp
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
            Form Log = new FormLog();
            DialogResult result = Log.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void nuevaBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormBusqueda());
        }

        private void AbrirHijo(object formHijo)
        {
            Form Hijo = formHijo as Form;
            Hijo.TopLevel = false;
            this.Wrapper.Controls.Add(Hijo);
            this.Wrapper.Tag = Hijo;
            Hijo.Show();
            busquedaToolStripMenuItem.ForeColor = Color.White;
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void nuevaBusquedaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            busquedaToolStripMenuItem.ForeColor = Color.Black;
            nuevaBusquedaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void nuevaBusquedaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            nuevaBusquedaToolStripMenuItem.ForeColor = Color.White;
        }

        private void busquedaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            busquedaToolStripMenuItem.ForeColor = Color.White;
        }
    }
}
