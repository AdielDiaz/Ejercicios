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
    public partial class Consultas2 : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=proyectoparcial3;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar3_Click(object sender, EventArgs e)
        {
            DataTable registros = new DataTable();
            registros.Columns.AddRange(new DataColumn[] {

                new DataColumn("Codigo",typeof(string)),
                new DataColumn("Nombre",typeof(string)),
                new DataColumn("Carrera",typeof(string)),
                new DataColumn("Correo",typeof(string)),
                new DataColumn("Telefono",typeof(string)),


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

                        dr["Código"].ToString(),
                        dr["Nombre"].ToString(),
                        dr["Carrera"].ToString(),
                        dr["Correo"].ToString(),
                        dr["Teléfono"].ToString()
                        );
                }
            }
            con.Close();
            GVConsultar2.DataSource = registros;
            GVConsultar2.DataBind();
        }
    }
}