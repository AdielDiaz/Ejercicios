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
    public partial class Consultas : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyectoparcial3;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar2_Click(object sender, EventArgs e)
        {
            DataTable registros = new DataTable();
            registros.Columns.AddRange(new DataColumn[] {
                new DataColumn("Id",typeof(string)),
                new DataColumn("Usuario",typeof(string)),
                new DataColumn("Contraseña",typeof(string)),
                new DataColumn("Codigo",typeof(string)),
                new DataColumn("Nombre",typeof(string)),
                new DataColumn("Carrera",typeof(string)),
                new DataColumn("Correo",typeof(string)),
                new DataColumn("Telefono",typeof(string)),
                new DataColumn("Facultad",typeof(string)),

            });

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select id, usuario, contraseña, código, nombre, carrera, correo, teléfono, facultad from Usuarios");
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    registros.Rows.Add(
                        dr["Id"].ToString(),
                        dr["Usuario"].ToString(),
                        dr["Contraseña"].ToString(),
                        dr["Código"].ToString(),
                        dr["Nombre"].ToString(),
                        dr["Carrera"].ToString(),
                        dr["Correo"].ToString(),
                        dr["Teléfono"].ToString(),
                        dr["Facultad"].ToString()
                        );
                }
            }
            con.Close();
            GVConsultar.DataSource = registros;
            GVConsultar.DataBind();
        }
        protected void gv_Lista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int valor = Convert.ToInt32(GVConsultar.DataKeys[index].Value);
                Response.Redirect("Eliminar.aspx?key=" + valor);
            }

            if (e.CommandName == "Modificar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int valor = Convert.ToInt32(GVConsultar.DataKeys[index].Value);
                Response.Redirect("Modificar.aspx?key=" + valor);
            }

        }
    }
}
