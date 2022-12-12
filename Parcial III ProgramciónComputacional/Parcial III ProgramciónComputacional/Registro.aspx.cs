using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Parcial_III_ProgramciónComputacional
{
    public partial class Registro : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyectoparcial3;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null) 
            {
                Response.Redirect("login.aspx");            
            }

            Label3.Text = "¡Bienvenido!:" + Session["usuario"].ToString();

            ListItem i;
            i = new ListItem("Administrador", "ADM");
            ddlLista.Items.Add(i);
            i = new ListItem("Ciencia y Tecnología", "CYT");
            ddlLista.Items.Add(i);
            i = new ListItem("Ingeniería y Arquitectura", "IYA");
            ddlLista.Items.Add(i);
        }

        protected void registrar_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO usuarios(usuario, contraseña, código, nombre, usuario, carrera, correo, teléfono, facultad) values ('" + usuarioreg.Text + "', '" + passwordreg.Text + "', '" + id.Text + "', '" + nombre.Text + "',  '" + carrera.Text + "',  '" + correo.Text + "',  '" + telefono.Text + "', '" + ddlLista.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            Label2.Text = "Datos guardados";
        }
    }
}