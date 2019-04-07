using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertFa_Click(object sender, EventArgs e)
        {
            double grados1;
            Fahrenheit fahrenheitGrados;
            double resultadoFa;
            if(txtFahrenheitPrincipal.Text=="")
            {
                MessageBox.Show("Debe Ingresar el valor de grados Fahrenheit!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               if(double.TryParse(txtFahrenheitPrincipal.Text,out grados1))
                {
                    fahrenheitGrados = (Fahrenheit)grados1;
                    resultadoFa = fahrenheitGrados.GetCantidadGrados();
                    txtFahrenheit1.Text = resultadoFa.ToString();

                    txtCelsius1.Text = (((Celsius)fahrenheitGrados).GetCantidadGrados()).ToString();
                    
                    txtKelvin1.Text = (((Kelvin)fahrenheitGrados).GetCantidadGrados()).ToString();
                }
            }
        }

        private void btnConvertCe_Click(object sender, EventArgs e)
        {
            double grados2;
            Celsius celsiusGrados;
            double resultadoCe;
            if (txtCelsiusPrincipal.Text == "")
            {
                MessageBox.Show("Debe Ingresar el valor de grados Celsius!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (double.TryParse(txtCelsiusPrincipal.Text, out grados2))
                {
                    celsiusGrados = (Celsius)grados2;
                    resultadoCe =  celsiusGrados.GetCantidadGrados();
                    txtCelsius2.Text = resultadoCe.ToString();

                    txtFahrenheit2.Text = (((Fahrenheit)celsiusGrados).GetCantidadGrados()).ToString();

                    txtKelvin2.Text = (((Kelvin)celsiusGrados).GetCantidadGrados()).ToString();
                }
            }
        }

        private void btnConvertKe_Click(object sender, EventArgs e)
        {
            double grados3;
            Kelvin kelvinGrados;
            double resultadoKe;
            if (txtKelvinPrincipal.Text == "")
            {
                MessageBox.Show("Debe Ingresar el valor de grados Kelvin!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (double.TryParse(txtKelvinPrincipal.Text, out grados3))
                {
                    kelvinGrados = (Kelvin)grados3;
                    resultadoKe = kelvinGrados.GetCantidadGrados();
                    txtKelvin3.Text = resultadoKe.ToString();

                    txtFahrenheit3.Text = (((Fahrenheit)kelvinGrados).GetCantidadGrados()).ToString();

                    txtCelsius3.Text = (((Celsius)kelvinGrados).GetCantidadGrados()).ToString();
                }
            }
        }
    }
}
