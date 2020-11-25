using Auditech_Web.Models;
using Auditech_Web.Services.TipoUsuarios;
using Auditech_Web.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auditech_Web
{
    public partial class Login : System.Web.UI.Page
    {
        private IUsuarioService uService = new UsuarioService();
        private ITipoUsuarioService tuService = new TipoUsuarioService();

        protected async Task Autenticacao()
        {
            string cpf = txtCpf.Text;
            string dtNascimento = string.Format("{0:d}", txtDtNasc.Text);

            if(cpf == null && dtNascimento == null)
            {
                Response.Redirect("Login.aspx?CamposVazios");
            }
            else
            {
                Usuario u = await uService.GetLoginUsuario(cpf, dtNascimento);

                if(u.idTipoUsuario == 1 || u.idTipoUsuario == 3|| u.idTipoUsuario == 5)
                {

                    if (u.idUsuario == 0)
                    {
                        Response.Redirect("Login.aspx?CPF_ou_Data_de_Nascimento_errados");
                    }
                    else
                    {
                        string sessionId = string.Empty;

                        if (u.idUsuario != 0)
                        {
                            int idUsuario = u.idUsuario;
                            Session["teste"] = idUsuario;
                            sessionId = Convert.ToString(Session["teste"]);
                        }
                        if (sessionId == null)
                        {
                            Response.Redirect("Login.aspx?Session_IdUsuario_vazia_antes_de_passar_informaçao");
                        }
                        else
                        {
                            Response.Redirect("TelaInicial.aspx");
                            Session["usuarioid"] = u.idUsuario;
                            //Response.Redirect("Login.apsx?id_vazio");
                        }
                    }
          
                }
                else
                {
                    Response.Redirect("Login.aspx?SemEntradaValida");
                }
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtCpf.Text != null && txtDtNasc.Text != null)
            {
                RegisterAsyncTask(new PageAsyncTask(Autenticacao));
            }
            else
            {
                Response.Redirect("Login.aspx?Campos CPF e Data de Nascimento vazio");
            }
        }
    }
}