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

namespace FormEjercicio63
{
    public partial class FormEjercicio63 : Form
    {
        private DateTime _fechaFin = DateTime.Now;
        
        private TimeSpan _time = new TimeSpan();
        public FormEjercicio63()
        {
            _fechaFin = DateTime.Now.AddMinutes(10);
            _time = _fechaFin - DateTime.Now;
            InitializeComponent();
            Thread oThread = new Thread(new ThreadStart(CalcularTime));
            oThread.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fechaFin = _fechaFin.AddMinutes(2);
        }

        private void CalcularTime()
        {
            while (DateTime.Now < _fechaFin)
            {
                _time = _fechaFin - DateTime.Now;
                try
                {
                    label1.Invoke((MethodInvoker)(() => label1.Text = _time.Seconds.ToString()));
                }
                catch { }
            }
        }

    
    }
}
