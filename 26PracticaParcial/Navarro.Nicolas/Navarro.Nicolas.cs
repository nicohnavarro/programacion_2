using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navarro.Nicolas
{
    public partial class Form1 : Form
    {
        private LosHilos hilos;
       
        public Form1()
        {
            InitializeComponent();
            hilos = new LosHilos();
            hilos.AvisoFin += MostrarMensajeFin;
        }

        public void MostrarMensajeFin(string mensaje)
        {
            
            MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this.hilos += 1;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Uops");
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.hilos.Bitacora, "ATENCION", MessageBoxButtons.OK);
        }
    }
}
