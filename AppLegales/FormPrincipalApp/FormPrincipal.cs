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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maximizar.Visible = true;
            restaurar.Visible = false;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormHijo(object formHijo)
        {
            //if (this.Wrapper.Controls.Count > 0)
            //    this.Wrapper.Controls.RemoveAt(0);
            Form formSon = formHijo as Form;
            formSon.TopLevel = false;
            this.Wrapper.Controls.Add(formSon);
            this.Wrapper.Tag = formSon;
            formSon.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormLog());
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormBusqueda());
        }
    }
}
