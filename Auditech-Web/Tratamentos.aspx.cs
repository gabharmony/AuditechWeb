using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Auditech_Web.Models;
using Auditech_Web.Services.Pacientes;
using Auditech_Web.Services.Tratamentos;
using Auditech_Web.Services.Usuarios;
using Library.Model;
using Library.Model.Enuns;

namespace Auditech_Web
{
    public partial class Tratamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Valores de Exercicio - ddlExercicio
                Dictionary<string, int> Exercicio = new Dictionary<string, int>()
                {
                    {"Ex 1", 1 },
                    {"Ex 2", 2 },
                    {"Ex 3", 3 },
                    {"Ex 4", 4 },
                    {"Ex 5", 5 },
                    {"Ex 6", 6 },
                    {"Ex 7", 7 },
                    {"Ex 8", 8 },
                    {"Ex 9", 9 },
                    {"Ex 10", 10 }
                };
                //Valores p/ Quantidade de Fase - ddlQtdeFases
                Dictionary<string, int> QtdeFases = new Dictionary<string, int>()
                {
                    {"Cinco Fases", 5 },
                    {"Seis Fases", 6 },
                    {"Sete Fases", 7 },
                    {"Oito Fases", 8 },
                    {"Nove Fases", 9 },
                    {"Dez Fases", 10},
                    {"Onze Fases", 11 },
                    {"Doze Fases", 12 },
                    {"Treze Fases", 13 },
                    {"Catorze Fases", 14 },
                    {"Quinze Fases", 15 },
                    {"Dezesseis Fases", 16 },
                    {"Dezessete Fases", 17 },
                    {"Dezoito Fases", 18 },
                    {"Dezenove Fases", 19 },
                    {"Vinte Fases", 20 }
                };
                //Valores p/ Duração de Fase - ddlDiaFase
                Dictionary<string, int> DuracaoFase = new Dictionary<string, int>()
                {
                    {"Três Dias", 3 },
                    {"Quatro Dias", 4 },
                    {"Cinco Dias", 5 },
                    {"Seis Dias", 6 },
                    {"Sete Dias", 7 },
                    {"Oito Dias", 8 },
                    {"Nove Dias", 9 },
                    {"Dez Dias", 10 }
                };
                //Valores p/ Quantidade de Treinos x Dia - ddlQtdeFase
                Dictionary<string, int> QtdeTreinos = new Dictionary<string, int>()
                {
                    {"Um Treino", 1 },
                    {"Dois Treinos", 2 },
                    {"Três Treinos", 3 }
                };
                //Valores p/ Intervalo Treino x Dia - ddlIntervaloTreino
                Dictionary<string, int> IntervaloTreinos = new Dictionary<string, int>()
                {
                    {"Quatro Horas", 4 },
                    {"Cinco Horas", 5 },
                    {"Seis Horas", 6 },
                    {"Sete Horas", 7 },
                    {"Oito Horas", 8 }
                };
                //Valores p/ Peso Treino - ddlPesoTreino
                Dictionary<double, string> PesoTreino = new Dictionary<double, string>()
                {
                    {0.1, "0,1" },
                    {0.2, "0,2" },
                    {0.3, "0,3" },
                    {0.4, "0,4" }
                };
                //Valores p/ Peso Desafio - ddlPesoDesafio
                Dictionary<double, string> PesoDesafio = new Dictionary<double, string>()
                {
                    {0.6, "0,6" },
                    {0.7, "0,7" },
                    {0.8, "0,8" },
                    {0.9, "0,9" }
                };

                int v;
                QtdeFases.TryGetValue("Dez Fases", out v);

                ddlExercicio.DataSource = Exercicio.Values;

                ddlQtdeFases.DataSource = QtdeFases.Values;
                ddlQtdeFases.SelectedValue = Convert.ToString(QtdeFases["Dez Fases"]);

                ddlDiaFase.DataSource = DuracaoFase.Values;
                ddlDiaFase.SelectedValue = Convert.ToString(DuracaoFase["Sete Dias"]);

                ddlQtdeTreinos.DataSource = QtdeTreinos.Values;
                ddlQtdeTreinos.SelectedValue = Convert.ToString(QtdeTreinos["Dois Treinos"]);

                ddlIntervaloTreino.DataSource = IntervaloTreinos.Values;
                ddlIntervaloTreino.SelectedValue = Convert.ToString(IntervaloTreinos["Seis Horas"]);

                ddlPesoTreino.DataSource = PesoTreino.Values;
                ddlPesoTreino.SelectedValue = Convert.ToString(PesoTreino[0.3]);

                ddlPesoDesafio.DataSource = PesoDesafio.Values;
                ddlPesoDesafio.SelectedValue = Convert.ToString(PesoDesafio[0.7]);

                ddlExercicio.DataBind();
                ddlQtdeFases.DataBind();
                ddlDiaFase.DataBind();
                ddlQtdeTreinos.DataBind();
                ddlIntervaloTreino.DataBind();
                ddlPesoTreino.DataBind();
                ddlPesoDesafio.DataBind();
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarPa.aspx");
        }

        private ITratamentoService tService = new TratamentoService();
        private IUsuarioService uService = new UsuarioService();
        private IPacienteService pService = new PacienteService();

        protected async Task ObterPorId()
        {

            int id = Convert.ToInt32(txtValorID.Text);
            Tratamento t = await tService.GetTratamentoAsync(id);
            
            string dtInicio = string.Format("{0:d}", t.dataInicio);

            if (!string.IsNullOrEmpty(dtInicio))
            {
                txtDtInicio.TextMode = TextBoxMode.SingleLine;
                txtDtInicio.Text = dtInicio;
            }
            else
            {
                txtDtInicio.TextMode = TextBoxMode.SingleLine;
                txtDtInicio.Text = dtInicio;
            }
            

            int idPaciente = t.pacienteIdPaciente;
            Paciente p = await pService.GetPacienteAsync(idPaciente);

            bool status = p.statusPaciente;

            if(status.Equals(true))
            {
                lblValorStatus.Text = "ATIVO";
            }
            else
            {
                lblValorStatus.Text = "INATIVO";
            }

            int idUsuario = Convert.ToInt32(p.usuarioIdusuario);
            Usuario u = await uService.GetUsuarioAsync(idUsuario);

            lblValorNome.Text = u.nome;
            //string dtNascimento = Convert.ToString(u.DataNascimento);
            lblValorDtNasc.Text = string.Format("{0:d}", u.dataNascimento);

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(ObterPorId));
        }
    }
}