using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form1 : Form
    {

        double operando1 = 0;
        double operando2 = 0;
        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void numeroPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += boton.Text;
        }

        private void operPuls(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }
        private void igualPuls(object sender, EventArgs e)
        {
            operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "x")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            else if (operacion == "x^")
            {
                resultado = Math.Pow(operando1, operando2);
            }
            label1.Text = Convert.ToString(resultado);
        }

        private void clearPulsado(object sender, EventArgs e)
        {
            operando1 = 0;
            operando2 = 0;
            label1.Text = "0";
        }

        private void comaPulsada(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void cuadradoPulsado(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(label1.Text);
            operando1 *= operando1;
            label1.Text = Convert.ToString(operando1);
        }

        private void raizPulsada(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(label1.Text);
            operando1 = Math.Sqrt(operando1);
            label1.Text = Convert.ToString(operando1);
        }

        private void piPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "3,14159265";
            }
            else
            {
                operacion = boton.Text;
                operando1 = Convert.ToDouble(label1.Text);
                operando1 *= 3.14159265;
                label1.Text = Convert.ToString(operando1);
            }
        }

        private void cuboPulsado(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(label1.Text);
            operando1 = operando1 * operando1 * operando1;
            label1.Text = Convert.ToString(operando1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(label1.Text);
            operando1 = 1 / operando1;
            label1.Text = Convert.ToString(operando1);
        }
    }
}
