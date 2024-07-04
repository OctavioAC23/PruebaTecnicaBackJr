using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=testback; user=root; password=Pezun@23";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Login, CONCAT(Nombre, ' ', Paterno, ' ', Materno) AS NombreCompleto, Sueldo, FechaIngreso FROM usuarios, empleados where usuarios.userId = empleados.userId ;";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string filePath = Server.MapPath("~/App_Data/Users.csv");

                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            // Escribir encabezados
                            writer.WriteLine("Login,Nombre Completo,Sueldo,Fecha Ingreso");

                            // Escribir datos
                            while (reader.Read())
                            {
                                string login = reader["Login"].ToString();
                                string nombreCompleto = reader["NombreCompleto"].ToString();
                                string sueldo = reader["Sueldo"].ToString();
                                string fechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]).ToString("yyyy-MM-dd");

                                writer.WriteLine($"{login},{nombreCompleto},{sueldo},{fechaIngreso}");
                            }
                        }

                        // Descargar el archivo
                        Response.ContentType = "text/csv";
                        Response.AppendHeader("Content-Disposition", $"attachment; filename=Users.csv");
                        Response.TransmitFile(filePath);
                        Response.End();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}