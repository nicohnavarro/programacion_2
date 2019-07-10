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
using Entidades;

namespace Carreras
{
    public partial class Form1 : Form
    {
        private List<Persona> _corredores;
        private List<Thread> _corredoresActivos;
        private bool _hayGanador;

        public Form1()
        {
            InitializeComponent();
            this._corredores = new List<Persona>();
            this._corredoresActivos = new List<Thread>();
            this._corredores.Add(new Persona("Fernando", 5, Corredor.Carril.Carril_1));
            this._corredores.Add(new Persona("Nicolas", 3, Corredor.Carril.Carril_2));
            this._hayGanador = false;
        }

        private void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }

        private void HayGanador(Corredor corredor)
        {
            this._hayGanador = true;
            foreach (Thread hilo in this._corredoresActivos)
            {
                if(hilo.IsAlive)
                    hilo.Abort();
            }
            this._corredoresActivos.Clear();
            string path = string.Format(@"{0}\Ganadores.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            corredor.Guardar(path);
            MessageBox.Show("Tenemos un Ganador :" + corredor.ToString() + "", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LimpiarCarriles();
        }

        private void AnalizarCarrera(ProgressBar carril,int avance,Corredor corredor)
        {
            if (!this._hayGanador)
            {
                int valor = 0;
                valor = carril.Value + avance;

                if (valor < carril.Maximum)
                    carril.Value += avance;
                else if (valor > carril.Maximum)
                {
                    carril.Value = carril.Maximum;
                    this.HayGanador(corredor);
                } 
            }
                
        }

        private void PersonaCorriendo(int avance,Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                Persona.CorrenCallback d = new Persona.CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if(corredor.CarrilElegido==Corredor.Carril.Carril_1)
                    AnalizarCarrera(pgbCarril1, avance, corredor);
                if (corredor.CarrilElegido == Corredor.Carril.Carril_2)
                    AnalizarCarrera(pgbCarril2, avance, corredor);
                // Aquí irá el código del alumno
            }
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            foreach(Persona per in this._corredores)
            {
                per.Corriendo += this.PersonaCorriendo;
                this._corredoresActivos.Add(new Thread(per.Correr));
            }
            foreach (Thread hilo in this._corredoresActivos)
            {
                hilo.Start();
            }

        }
    }
}
