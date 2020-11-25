﻿<%@ Page Title="Meu Perfil" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Profissional.aspx.cs" Inherits="Auditech_Web.Profissional" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Página foi feita a partir da Master: Principal.Master-->
    <!--A DIV content_profissional foi feita para ajustar o espaço das informações e ajustar a localização dos botões-->
    <div id="content_profissional">
        <br><br>
        <div class="container">
            <!--Aqui as informações foram separadas em Colunas para cada informação-->
            <div class="row">
                <!--ID-->
                <div class="col-6 col-sm-6">
                    <asp:Label ID="lblID" runat="server" Font-Size="17px" Font-Bold="true" Text="ID: "></asp:Label>
                    <asp:Label ID="lblValorID" runat="server" Text=""></asp:Label>
                </div>
                <!--Nome-->
                <div class="col-6 col-sm-4">
                    <asp:Label ID="lblNome" runat="server" Font-Size="17px" Font-Bold="true" Text="Nome: "></asp:Label>
                    <asp:Label ID="lblValorNome" runat="server" Text=""></asp:Label>
                </div>
                <br /><br />
                <div class="w-100 d-none d-md-block"></div>
                <!--CPF-->
                <div class="col-6 col-sm-4">
                    <asp:Label ID="lblCPF" runat="server" Font-Size="17px" Font-Bold="true" Text="CPF: "></asp:Label>
                    <asp:Label ID="lblValorCPF" runat="server" Text=""></asp:Label>
                </div>
                <br /><br />
                <div class="w-100 d-none d-md-block"></div>
                <!--Endereço/Rua/Avenida-->
                <div class="col-6 col-sm-6">
                    <asp:Label ID="lblEndereco" runat="server" Font-Size="17px" Font-Bold="true" Text="Endereço: "></asp:Label>
                    <asp:Label ID="lblValorEndereco" runat="server" Text=""></asp:Label>
                </div>
                <!--Numero da Casa/Apartamento-->
                <div class="col-6 col-sm-4">
                    <asp:Label ID="lblNumero" runat="server" Font-Size="17px" Font-Bold="true" Text="Número: "></asp:Label>
                    <asp:Label ID="lblValorNumero" runat="server" Text=""></asp:Label>
                </div>
                <br /><br />
                <div class="w-100 d-none d-md-block"></div>
                    <div class="col-6 col-sm-6"></div>
                <!--Complemento-->
                <div class="col-6 col-sm-4">
                    <asp:Label ID="lblComplemento" runat="server" Font-Size="17px" Font-Bold="true" Text="Complemento: "></asp:Label>
                    <asp:Label ID="lblValorComplemento" runat="server" Text=""></asp:Label>
                </div>
                <br /><br />
                <div class="w-100 d-none d-md-block"></div>
                <!--Clínica-->
                <div class="col-6 col-sm-4">
                    <asp:Label ID="lblClinica" runat="server" Font-Size="17px" Font-Bold="true" Text="Clínica: "></asp:Label>
                    <asp:Label ID="lblValorClinica" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <!--DIV contendo os botões Editar e Voltar-->
    <div id="content_profissional_buttons">
        <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary btn-lg" BackColor="#1198ff" Width="120px" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-primary btn-lg" Width="120px" Text="Voltar" OnClick="btnVoltar_Click" />
    </div>
</asp:Content>
