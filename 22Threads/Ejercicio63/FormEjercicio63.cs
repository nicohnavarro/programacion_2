using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{
    public partial class FormEjercicio63 : Form
    {
        public FormEjercicio63()
        {
            InitializeComponent();
            Thread t = new Thread(AsignarHora);
            t.Start(1000);
        }

        public void AsignarHora()
        {
            
            DateTime fecha = new DateTime();
            if (this.lblFecha.InvokeRequired)
            {
                this.lblFecha.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblFecha.Text = fecha.ToLongTimeString();
                }
                );
            }
            else
            {
                this.lblFecha.Text =fecha.ToLongTimeString();
            }

            lblFecha.Text = fecha.ToLongTimeString().ToString();
        }
    }
}
