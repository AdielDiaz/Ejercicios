using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
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
            textBox3.Text = "La suma es: " + sumar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double sumar(double número1, double número2) 
        {
            double sumar = número1 + número2;
            return sumar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "La resta es: " + restar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double restar(double número1, double número2)
        {
            double restar = número1 - número2;
            return restar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "La multiplicación es: " + multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double multiplicar(double número1, double número2)
        {
            double multiplicar = número1 * número2;
            return multiplicar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "La división es: " + dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double dividir(double número1, double número2)
        {
            double dividir = número1 / número2;
            return dividir;
        }

        private void limpiar() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
