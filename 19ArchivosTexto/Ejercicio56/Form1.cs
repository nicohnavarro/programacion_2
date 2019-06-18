using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio56
{
    public partial class formNotepad : Form
    {
        string path;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;

        public formNotepad()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter= "Archivos de texto(.txt)|*.txt|Archivos de datos (.dat)|*.dat";
            saveFileDialog.Filter = "Archivos de texto(.txt)|*.txt|Archivos de datos (.dat)|*.dat";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCaracteres();
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            ShowCaracteres();
        }

        public void ShowCaracteres()
        {
            toolStripStatusLabel1.Text = richTextBoxText.Text.Length.ToString() + " Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                //Ejercicio 58
                switch(openFileDialog.FilterIndex)
                {
                    case 1:
                        richTextBoxText.Text = new PuntoTxt().Leer(path);
                        break;
                    case 2:
                        PuntoDat puntoDat=new PuntoDat();
                        puntoDat = puntoDat.Leer(path);
                        richTextBoxText.Text = puntoDat.Contenido;
                        break;

                }
                //Ejercicio 56
                /*StreamReader sr = new StreamReader(path);
                richTextBoxText.Text = sr.ReadToEnd();
                sr.Close();*/
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {

                Guardar();
            }
            else
                GuardarComo();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void Guardar()
        {
            //Ejercicio 58
            switch(Path.GetExtension(path))
            {
                case ".txt":
                    new PuntoTxt().Guardar(path, richTextBoxText.Text);
                    break;
                case ".dat":
                    PuntoDat puntoDat=new PuntoDat();
                    puntoDat.Contenido = richTextBoxText.Text;
                    puntoDat.Guardar(path, puntoDat);
                    break;
            }

            //Ejercicio 56
            //StreamWriter sw = new StreamWriter(path);
            //sw.Write(richTextBoxText.Text);
            //sw.Close();
        }
        private void GuardarComo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                switch(saveFileDialog.FilterIndex)
                {
                    case 1:
                        new PuntoTxt().GuardarComo(path, richTextBoxText.Text);
                        break;
                    case 2:
                        PuntoDat puntoDat = new PuntoDat();
                        puntoDat.Contenido = richTextBoxText.Text;
                        puntoDat.Guardar(path, puntoDat);
                        break;
                }
            }
        }
    }

}
