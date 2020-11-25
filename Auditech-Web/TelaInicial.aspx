<%@ Page Title="Início" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="TelaInicial.aspx.cs" Inherits="Auditech_Web.TelaInicial" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Página foi feita a partir da Master: Principal.Master-->
    <div class="container">
        <!--DIV para a opção "Organizar Por" 
             O DropDown recebe as informações do enumerador em Library/Model/Enuns/OrganizarEnum.cs -->
        <div id="organizar">
            <nav class="nav justify-content-end" id="organizarPor">
                <asp:Label ID="lblOrganizar" runat="server" Text="Organizar por: "></asp:Label>
                 &nbsp;
                <asp:DropDownList ID="ddlOrganizar" runat="server"></asp:DropDownList>
            </nav>
        </div>
        <br />
    </div>
    <!--DIV onde está os botões para cada Paciente-->
        <!--INÍCIO DIV pacientes-->
    <div id="pacientes">
        <!--DIV criada para cada card funcionar como botão para as informações do Paciente-->
            <!--INÍCIO DIV paciente1-->
        <div class="btn" id="paciente1" role="button">
            <div class="card text-center btnpaciente">
                <asp:ImageButton ID="imgPaciente1" runat="server" CssClass="pacnteimg" BorderColor="#12DAFA" ImageUrl="~/img/paciente.png" OnClick="imgPaciente1_Click"/>
                <div class="card-body" id="pacnte1">
                    <asp:Label ID="lblNmPaciente1" runat="server" Text="nomePaciente"></asp:Label> 
                    <br />
                    <asp:Label ID="lblTratamento1" runat="server" Text="Tratamento: "></asp:Label>
                    <asp:Label ID="lblValorTratamento1" runat="server" Text="(id/nome)"></asp:Label>
                    <br />
                    <asp:Label ID="lblStatus1" runat="server" Text="Status: "></asp:Label>
                    <asp:Label ID="lblValorStatus1" runat="server" Text="Valor"></asp:Label>
                </div>
            </div>
        </div>
            <!--FIM DIV paciente1-->
            <!--INÍCIO DIV paciente2-->
        <div class="btn" id="paciente2" role="button">
            <div class="card text-center btnpaciente">
                <asp:ImageButton ID="imgPaciente2" runat="server" CssClass="pacnteimg" BorderColor="#12DAFA" ImageUrl="~/img/paciente.png"/>
                <div class="card-body" id="pacnte2">
                    <asp:Label ID="lblNmPaciente2" runat="server" Text="nomePaciente"></asp:Label> 
                    <br />
                    <asp:Label ID="lblTratamento2" runat="server" Text="Tratamento: "></asp:Label>
                    <asp:Label ID="lblValorTratamento2" runat="server" Text="(id/nome)"></asp:Label>
                    <br />
                    <asp:Label ID="lblStatus2" runat="server" Text="Status: "></asp:Label>
                    <asp:Label ID="lblValorStatus2" runat="server" Text="Valor"></asp:Label>
                </div>
            </div>
        </div>
            <!--FIM DIV paciente2-->
    </div>
    <!--FIM DIV pacientes-->
    <!--DIV com os botões: Cadastrar Paciente e Perfil-->
    <div id="content_telainicial_buttons">
        <asp:Button ID="btnCadastrarPacnte" runat="server" CssClass="btn btn-primary btn-lg" Widht="120px" Text="Cadastrar Paciente" OnClick="btnCadastrarPacnte_Click" />
        <asp:Button ID="btnPerfil" runat="server" CssClass="btn btn-primary btn-lg" Width="120px" Text="Perfil" OnClick="btnPerfil_Click" />
    </div>
</asp:Content>
