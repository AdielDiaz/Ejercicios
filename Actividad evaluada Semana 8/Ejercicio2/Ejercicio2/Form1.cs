using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double número1 = Convert.ToDouble(textBox1.Text);
            double número2 = Convert.ToDouble(textBox2.Text);

            if (checkBox1.Checked == true) 
            {
                textBox3.Text = "La suma es: " + sumar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }

            if (checkBox2.Checked == true) 
            {
                textBox3.Text = "La resta es: " + restar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }

            if (checkBox3.Checked == true)
            {
                textBox3.Text = "La multiplicación es: " + multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }

            if (checkBox4.Checked == true)
            {
                textBox3.Text = "La división es: " + dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
        }
        public double sumar(double número1, double número2) 
        {
            double sumar = número1 + número2;
            return sumar;
        }
        public double restar(double número1, double número2)
        {
            double restar = número1 - número2;
            return restar;
        }
        public double multiplicar(double número1, double número2)
        {
            double multiplicar = número1 * número2;
            return multiplicar;
        }
        public double dividir(double número1, double número2)
        {
            double dividir = número1 / número2;
            return dividir;
        }

        public void limpiar() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
