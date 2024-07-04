using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Data;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Asn1.Mozilla;
namespace Modelo
{
    public class Usuarios
    {
        ConexionBD conectar;

        private DataTable dropTop()
        {
            DataTable table = new DataTable();
            conectar = new ConexionBD();

            conectar.AbrirConexion();
            string consulta = string.Format("SELECT Login, CONCAT(Nombre, ' ', Paterno, ' ', Materno) AS NombreCompleto, Sueldo FROM usuarios, empleados where usuarios.userId = empleados.userId ORDER BY Sueldo DESC LIMIT 10;");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(table);
            conectar.cerrarConexcion();
            
            return table;
        }

        public void grid_Top(GridView grid)
        {
            grid.DataSource = dropTop();
            grid.DataBind();
        }


    }
}
