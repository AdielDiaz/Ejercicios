using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(txtID.Text, out ID))

            {
                errorProvider1.SetError(txtID, "No ingresó un ID válido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingreso el Nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingreso el DUI");
                txtDUI.Focus();
                return;
            }

            errorProvider1.SetError(txtDUI, "");

            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))

            {
                errorProvider1.SetError(txtSalario, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");


            Empleado.Id = Convert.ToInt32(txtID.Text);
            Empleado.Nombre = txtNombre.Text;
            Empleado.DUI = txtDUI.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);
            labelRegistro.Text = "¡Registro guardado!";

        }

        private void btnAFP_Click(object sender, EventArgs e)
        {
            txtAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void btnISSS_Click(object sender, EventArgs e)
        {
            txtISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void btnNeto_Click(object sender, EventArgs e)
        {
            txtNeto.Text = Empleado.Neto(Empleado.Salario).ToString();
        }
    }
}
