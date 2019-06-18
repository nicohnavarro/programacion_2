using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class FormPersona : Form
    {
        List<Persona> listaPersonas;
        public FormPersona()
        {
            InitializeComponent();
            listaPersonas = new List<Persona>();
            listaPersonas = PersonaDAO.Leer();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            LeerTodo();

        }

        private void LeerTodo()
        {
            lstPersonas.Items.Clear();
            foreach(Persona p in PersonaDAO.Leer())
            {
                lstPersonas.Items.Add(p);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private bool NombreVacio()
        {
            if(String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("No se introdujo ningun Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("No se introdujo ningun Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;

        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            LeerTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!NombreVacio())
            {
                PersonaDAO.Guardar(txtNombre.Text, txtApellido.Text);
                LeerTodo();
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona personSelect = (Persona)lstPersonas.SelectedItem;
            if(personSelect!=null)
            {
                if(!NombreVacio())
                {
                    Persona persona = new Persona(personSelect.Id, txtNombre.Text,txtApellido.Text);
                    PersonaDAO.Modificar(persona);
                    LeerTodo();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Elija una persona...", "No se elegio una persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Persona personSelect = (Persona)lstPersonas.SelectedItem;
            if(personSelect!=null)
            {
                txtNombre.Text = personSelect.Nombre;
                txtApellido.Text = personSelect.Apellido;
            }
            else
            {
                MessageBox.Show("Elija otra persona ...", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona personSelect = (Persona)lstPersonas.SelectedItem;
            if (personSelect != null)
            {
                PersonaDAO.Borrar(personSelect.Id);
                LeerTodo();
            }
            else
            {
                MessageBox.Show("No se elijio una persona", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
    }
}
