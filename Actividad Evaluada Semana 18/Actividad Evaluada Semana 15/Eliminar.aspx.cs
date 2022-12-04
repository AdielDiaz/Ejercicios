using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Actividad_Evaluada_Semana_15
{
    public partial class Eliminar : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyecto;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {
            String valor = Convert.ToString(Request.QueryString["key"]);

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from Usuarios where Id= " + valor);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Consultas.aspx");
        }
    }
}