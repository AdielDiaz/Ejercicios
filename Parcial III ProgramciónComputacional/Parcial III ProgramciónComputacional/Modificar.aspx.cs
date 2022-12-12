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
    public partial class Modificar : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyectoparcial3;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem i;
            i = new ListItem("Administrador", "ADM");
            ddlLista2.Items.Add(i);
            i = new ListItem("Ciencia y Tecnología", "CYT");
            ddlLista2.Items.Add(i);
            i = new ListItem("Ingeniería y Arquitectura", "IYA");
            ddlLista2.Items.Add(i);
            idoculto.Visible = false;
            String valor = Convert.ToString(Request.QueryString["key"]);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, usuario, contraseña, código, nombre, carrera, correo, teléfono, facultad from usuarios where Id = "  + valor;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                idoculto.Text = dr["id"].ToString();

            }
            con.Close();
        }

        protected void modificar_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update usuarios set usuario='" + usuariomod.Text + "', contraseña='" + passwordmod.Text + "', código='" + idmod.Text + "', nombre='" +nombremod.Text + "', carrera='" + carreramod.Text + "', correo='" + correomod.Text + "', teléfono='" + telefonomod.Text + "', facultad='" + ddlLista2.Text + "' where Id=" + idoculto.Text;
            cmd2.ExecuteNonQuery();
            con.Close();
            Label5.Text = "Datos guardados";
        }
    }
}
