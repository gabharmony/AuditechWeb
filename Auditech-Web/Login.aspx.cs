using Auditech_Web.Models;
using Auditech_Web.Services.TipoUsuarios;
using Auditech_Web.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            long cpfFormatar = Convert.ToInt64(txtCpf.Text);
            long dt = Convert.ToInt64(txtDtNasc.Text);

            string cpf = String.Format(@"{0:000\.000\.000\-00}", cpfFormatar);
            string dtNascimento = String.Format(@"{0:00\-00\-0000}", dt);

            if (cpf == null && dtNascimento == null)
            {
                Response.Redirect("Login.aspx?CamposVazios");
            }
            else
            {
                Usuario u = await uService.GetLoginUsuario(cpf, dtNascimento);

                if (u.idTipoUsuario == 1 || u.idTipoUsuario == 3 || u.idTipoUsuario == 5)
                {

                    if (u.idUsuario == 0)
                    {
                        Response.Redirect("Login.aspx?CPF_ou_Data_de_Nascimento_errados");
                    }
                    else
                    {
                        if (u.idUsuario != 0)
                        {
                            int idUsuario = u.idUsuario;
                            Response.Redirect(string.Format("TelaInicial.aspx?qs={0}", idUsuario));
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
            
            //string texto = txtCpf.Text;
            //Response.Redirect(string.Format("Login.aspx?{0}", texto));
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