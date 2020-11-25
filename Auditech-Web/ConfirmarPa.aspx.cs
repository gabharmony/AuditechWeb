using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auditech_Web
{
    public partial class ConfirmarPa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroPa.aspx");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaInicial.aspx");
        }
    }
}