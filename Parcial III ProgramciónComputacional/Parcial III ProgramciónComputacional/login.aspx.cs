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
    public partial class _default : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyectoparcial3;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where usuario='" + usuario.Text + "' and contraseña='" + password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Session["usuario"] = dr["usuario"].ToString();
                String facultad = dr["facultad"].ToString();
                if (facultad == "ADM")
                {
                    Response.Redirect("Menú.aspx");
                }
                else { Response.Redirect("Menú2.aspx"); }
            }
            con.Close();
            Label1.Text = "Usuario o contraseña inválidos";
        }
    }
}