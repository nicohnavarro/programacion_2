using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class FormDt : Form
    {
        private DirectorTecnico dt;
        public FormDt()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            int edad;
            int dni;
            int experiencia;
            bool a =int.TryParse(numericUpDownEdad.Value.ToString(), out edad);
            bool b = int.TryParse(numericUpDownDni.Value.ToString(), out dni);
            bool c = int.TryParse(numericUpDownExperiencia.Value.ToString(), out experiencia);
            if(a && b && c)
            {
                dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text,edad, dni, experiencia);
                MessageBox.Show("Se ha creado el DT!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if(dt is null)
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            }
            else if(dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto.");
                MessageBox.Show(dt.Mostrar());
                TextBox info = new TextBox();
                info.Text = dt.Mostrar();
                info.Show();
            }
            else
            {
                MessageBox.Show("El DT no es apto.");
                MessageBox.Show(dt.Mostrar());
            }
        }
    }
}
