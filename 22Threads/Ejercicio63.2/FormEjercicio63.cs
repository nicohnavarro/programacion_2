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

namespace Ejercicio63._2
{
    public partial class FormEjercicio63 : Form
    {
        Thread thread1;
        public FormEjercicio63()
        {
            InitializeComponent();

        }

        public void AsignarHora()
        {
            while(true)
            {
                if(lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke((MethodInvoker)delegate () { lblHora.Text = DateTime.Now.ToString(); });
                }
                else
                {
                    lblHora.Text = DateTime.Now.ToString();
                }
                Thread.Sleep(1000);
            }
        }

        private void FormEjercicio63_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread1.Abort();
        }

        private void FormEjercicio63_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
            thread1 = new Thread(AsignarHora);
            thread1.Start();
        }
    }
}
