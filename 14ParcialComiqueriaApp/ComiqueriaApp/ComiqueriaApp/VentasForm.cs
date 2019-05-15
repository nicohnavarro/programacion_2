using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comiqueriaVe;
        Producto productoVe;
        int cantidad;
        public VentasForm()
        {
            InitializeComponent();
        }

        public VentasForm(Comiqueria comiqueria,Producto producto):this()
        {
            this.comiqueriaVe = comiqueria;
            this.productoVe = producto;
            this.cantidad = 1;
            lblDescripcion.Text = producto.Descripcion;
            lblPrecioFinal2.Text = Venta.CalcularPrecioFinal(productoVe.Precio, cantidad).ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.cantidad =(int) numericUpDownCantidad.Value;
            lblPrecioFinal2.Text=Venta.CalcularPrecioFinal(productoVe.Precio, cantidad).ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(cantidad>productoVe.Stock)
            {
                MessageBox.Show("Supero el stock disponible \n", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(cantidad<=productoVe.Stock)
            {
                comiqueriaVe.Vender(productoVe, cantidad);
                MessageBox.Show("Se Vendio..!","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.OK;
                
            }
        }
    }
}
