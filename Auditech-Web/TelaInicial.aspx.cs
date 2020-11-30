using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Auditech_Web.Models;
using Auditech_Web.Services.Pacientes;
using Auditech_Web.Services.Profissionais;
using Auditech_Web.Services.Tratamentos;
using Auditech_Web.Services.Usuarios;
using Library.Model.Enuns;

namespace Auditech_Web
{
    public partial class TelaInicial : System.Web.UI.Page
    {
        private ITratamentoService tService = new TratamentoService();
        private IPacienteService pService = new PacienteService();
        private IUsuarioService uService = new UsuarioService();
        private IProfissionalService pfService = new ProfissionalService();

        protected async Task ResgatarInfo() 
        {
            string loginId = Request.QueryString["qs"];

            int id = Convert.ToInt32(loginId);

            if(id == 0)
            {
                Response.Redirect("Login.aspx?QueryString_vazio");
            }
            //if(loginId != "10")
            //{
             //   const string urlBase = "Login.aspx?SessionString_vazio";

              //  string idlogin = loginId;

              //  string url = string.Format("{0}{1}", urlBase, idlogin);

              //  Response.Redirect(url);
                //int id = 11;
                Usuario u = await uService.GetUsuarioAsync(id);

                Button btnUsuario = (Button)Master.FindControl("btnUsuario");
                btnUsuario.Text = u.nome;

            //}

            //if(loginId != 0)
            //{
                //string idUsuario = (string)Session["IdUsuario"];
               // int id = 11;
               // Usuario u = await uService.GetUsuarioAsync(id);

                //Button btnUsuario = (Button)Master.FindControl("btnUsuario");
                //btnUsuario.Text = u.nome;
                //Session["IdUsuario"] = u.idUsuario;
            //}
           // else
            //{
               // Response.Redirect("Login.aspx?Session_null");
            //}
            
        }

        //protected async Task InfoBotaoPaciente()
        //{
            //int id = (int)Session["IdUsuario"];
            //Usuario u = await uService.GetUsuarioAsync(id);

            //int consultProfissional = u.idUsuario;

            //int pacent1 = 1;
            //int pacent2 = 2;

                //Paciente pa = await pService.GetPacienteAsync(pacent1);
               // int idusuario1 = pa.usuarioIdusuario;
               // Usuario us = await uService.GetUsuarioAsync(idusuario1);
               // lblNmPaciente1.Text = us.nome;
                //Tratamento t = await tService.GetTratamentoAsync(pacent1);
               // lblValorTratamento1.Text = string.Format("{0}", t.idTratamento);
               // bool sttspac1 = pa.statusPaciente;
               // if(sttspac1.Equals(true))
               // {
              //      lblValorStatus1.Text = "ATIVO";
               // }
               // else
               // {
                //    lblValorStatus1.Text = "INATIVO";
               // }
                

                //Paciente pc = await pService.GetPacienteAsync(pacent2);
                //int idusuario2 = pc.usuarioIdusuario;
                //Usuario us1 = await uService.GetUsuarioAsync(idusuario2);
                //lblNmPaciente2.Text = us1.nome;
                //Tratamento t1 = await tService.GetTratamentoAsync(pacent2);
               // lblValorTratamento2.Text = string.Format("{0}", t1.idTratamento);
                //bool sttspac2 = pc.statusPaciente;
               // if(sttspac2.Equals(true))
               // {
               //     lblValorStatus2.Text = "ATIVO";
               // }
               // else
               // {
               //     lblValorStatus2.Text = "INATIVO";
               // }

        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {                
                RegisterAsyncTask(new PageAsyncTask(ResgatarInfo));
                //RegisterAsyncTask(new PageAsyncTask(InfoBotaoPaciente));

                ddlOrganizar.DataSource = Enum.GetValues(typeof(OrganizarEnum));
                ddlOrganizar.DataBind();
            }
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profissional.aspx");
        }

        protected void btnCadastrarPacnte_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroPa.aspx");
        }

        protected void imgPaciente1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ConsultarPa.aspx");
        }
    }
}