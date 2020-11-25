<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Auditech_Web.Login" Async="true" %>
<!--Essa página foi criada sem a Master-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/toastr.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/d7a880eefe.js"></script>
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootbox.min.js"></script>
    <script src="Scripts/toastr.min.js"></script>
</head>
    <!--Usado a class: login para atribuir a cor preta na página e a imagem de fundo.
        Class: login faz referência ao arquivo Site.css na pasta Content-->
<body class="login">
    <form id="form1" runat="server">
        <div>
            <!--DIV com a navbar contendo só a imagem, como no exemplo.
              Imagem na pasta img junto com as outras pastas-->
            <div id="header">
                <nav class="navbar navbar-dark" style="background-color: #000000;">
                    <a class="navbar-brand" href="#">
                        <img src="./img/Logo_02.jpeg" style="border-radius: 10px;" width="100" height="100" alt="" loading="lazy"/>
                    </a>
                </nav>
            </div>
            <!--Fim da DIV header c/navbar para imagem-->

            <!--Essa DIV contendo icons, campos e botões.
               Icons e Campos: Dentro da DIV com Class="form-check ..." e botões abaixo das 2 DIvs -->
            <div id="content">
                <br/><br/><br/>
                <div class="form-check form-check-inline">
                    <asp:Label ID="lblLoginCPF" runat="server" CssClass="form-check-input"> <i class="fas fa-user"></i> </asp:Label>
                    <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control" placeholder="CPF"></asp:TextBox>
                </div>
                <br/><br/>
                <div class="form-check form-check-inline">
                    <asp:Label ID="lblLoginDtNasc" runat="server" CssClass="form-check-input"> <i class="fas fa-key"></i> </asp:Label>
                    <asp:TextBox ID="txtDtNasc" runat="server" CssClass="form-control" placeholder="Data de Nascimento"></asp:TextBox>
                </div>
                <br/><br/>
                <asp:Button ID="btnEntrar" runat="server" CssClass="btn btn-primary btn-lg" Text="Entrar" OnClick="btnEntrar_Click" />
                <br />
                <asp:Button ID="btnRegistra" runat="server" CssClass="btn btn-link" Text="Registrar-se" />
            </div>
        </div>
    </form>
</body>
</html>
