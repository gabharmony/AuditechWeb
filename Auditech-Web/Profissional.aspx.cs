using Auditech_Web.Services.Clinicas;
using Auditech_Web.Services.Profissionais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auditech_Web
{
    public partial class Profissional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarPr.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TelaInicial");
        }

        private IProfissionalService pService = new ProfissionalService();
        private IClinicaService cService = new ClinicaService();

    }
}