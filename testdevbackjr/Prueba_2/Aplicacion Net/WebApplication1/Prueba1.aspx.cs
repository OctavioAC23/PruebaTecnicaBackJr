using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        Usuarios usuarios;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usuarios = new Usuarios();
                usuarios.grid_Top(grid_Top);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}