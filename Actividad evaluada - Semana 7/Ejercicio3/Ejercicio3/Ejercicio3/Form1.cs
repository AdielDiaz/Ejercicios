using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double suma = número1 + número2;
            label3.Text = "La suma es: " + suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double resta = número1 - número2;
            label3.Text = "La resta es: " + resta.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double multiplicacion = número1 * número2;
            label3.Text = "La multiplicación es: " + multiplicacion.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);
            double division = número1 / número2;
            label3.Text = "La division es: " + division.ToString();
        }
    }
}
