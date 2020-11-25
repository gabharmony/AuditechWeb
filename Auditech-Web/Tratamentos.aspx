<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tratamentos.aspx.cs" Inherits="Auditech_Web.Tratamentos" Async="true" %>
<!--Esta página foi criada sem a Master-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tratamento</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/toastr.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/d7a880eefe.js"></script>
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootbox.min.js"></script>
    <script src="Scripts/toastr.min.js"></script>
</head>
    <!--Usando a class: principal, pois ela usa as mesmas configurações que a páginas que usam a Master.
        Class: principal, faz referência ao arquivo Site.css na pasta Content-->
<body class="principal">
    <form id="form1" runat="server">
        <div>
            <div id="header">
                <!--Navbar contendo a Imagem Logo e as Informações do Paciente.
                    Imagem Logo está dentro da pasta img assim como as demais-->
                    <!--INÍCIO NAVBAR-->
                <nav class="navbar navbar-expand-lg navbar-light">
                    <a class="navbar-brand" href="#">
                        <img src="./img/Logo_02.jpeg" class="rounded" width="100" height="100" alt="" loading="lazy" />
                    </a>
                    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                        <div class="navbar-nav">
                            <!--Aqui as informações do Paciente foram separadas em Colunas-->
                                <!--INÍCIO das Informações-->
                            <div class="row" id="navbarRow">
                                <!--ID-->
                                <div class="col-6">
                                    <asp:Label ID="lblID" runat="server" Font-Bold="true" Text="ID: "></asp:Label>
                                    &nbsp;
                                    <asp:TextBox ID="txtValorID" runat="server" placeholder="Digite o ID"></asp:TextBox>
                                </div>
                                <!--STATUS-->
                                <div class="col-6 col-sm-auto">
                                    <asp:Label ID="lblStatus" runat="server" Font-Bold="true" Text="STATUS: "></asp:Label>
                                    &nbsp;
                                    <asp:Label ID="lblValorStatus" runat="server" Text="ATIVO / REPOUSO / INATIVO "></asp:Label>
                                </div>
                                <br /><br />
                                <!--Nome Paciente-->
                                <div class="col-6">
                                    <asp:Label ID="lblNmPaciente" runat="server" Font-Bold="true" Text="PACIENTE: "></asp:Label>
                                    &nbsp;
                                    <asp:Label ID="lblValorNome" runat="server" Text="Prenome / Nome Sobrenome"></asp:Label>
                                </div>
                                <!--Data de Nascimento-->
                                <div class="col-6 col-sm-auto">
                                    <asp:Label ID="lblDtNasc" runat="server" Font-Bold="true" Text="DATA NASCIMENTO: "></asp:Label>
                                    &nbsp;
                                    <asp:Label ID="lblValorDtNasc" runat="server" Text="DD/MM/AAAA"></asp:Label>
                                </div>
                            </div>
                            <!--FIM das Informações-->
                        </div>
                        <div class="form-inline">
                            <asp:Button ID="btnUsuario" runat="server" CssClass="btn btn-link" ForeColor="#28a745" Text="[Usuario]" />
                            <asp:Label ID="lblUsuario" runat="server" Text=""><i class="fas fa-user" style=" color: #28a745;"></i></asp:Label>
                        </div>
                    </div>
                </nav>
                <!--FIM NAVBAR-->
            </div>
            <!--INÍCIO DIV content-->
            <div id="content">
                <!--Aqui foi feita duas DIVs infoExer e observacao, afim de separar as Informações do Tratamento das Observações Clínicas-->
                <br />
                <!--INÍCIO DIV infoExer-->
                <div id="infoExer">
                    <!--Aqui as Informações foram separadas em 3 Colunas: dt | exc | parametros
                        dt(data de inicio e fim do Tratamento), exc(data de inicio e fim de cada exercicio), parametros(parâmetros do tratamento)-->
                    <div class="row">
                        <!--INÍCIO dt-->
                        <div class="col" id="dt">
                            <!--Label e TextBox referente a Data Início-->
                            <asp:Label ID="lblDtInicio" runat="server" Text="Data Início: "></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtDtInicio" runat="server" TextMode="Date" Text="24/10/2020"></asp:TextBox>
                            <br /><br />
                            <!--Label e TextBox referente a Data Término-->
                            <asp:Label ID="lblDtFim" runat="server" Text="Data Término: "></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="txtDtFim" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                        <!--FIM dt-->

                        <!--INÍCIO exc-->
                        <div class="col" id="exc">
                            <!--Label e DropDownList referente a Exercício
                                O DropDown recebe as informações do enumerador em Library/Model/Enuns/ExercicioEnum.cs-->
                            <asp:Label ID="lblExercicio" runat="server" Text="Exercício:"></asp:Label>
                            <br />
                            <asp:DropDownList ID="ddlExercicio" runat="server" Width="50px"></asp:DropDownList>
                            <br />
                            <!--Label e TextBox referente a Data Início-->
                            <asp:Label ID="lblDtIniExerc" runat="server" Text="Data Início:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtDtIniExerc" runat="server" TextMode="Date"></asp:TextBox>
                            <br />
                            <!--Label e TextBox referente a Data Término-->
                            <asp:Label ID="lblDtFimExerc" runat="server" Text="Data Término:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtDtFimExerc" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                        <!--FIM exc-->

                        <!--INÍCIO parametros-->
                        <div class="col" id="parametros">
                        <!--Aqui, cada <div class="row"> faz referência a uma linha com Label e DropDownList separados por coluna-->
                            <!--DIV contendo Label e DropDownList referente a "Quantidade Fases
                                 O DropDown recebe as informações do enumerador em Library/Model/Enuns/QtdeFasesEnum.cs"-->
                            <div class="row" id="row1">
                                <div class="col">
                                    <asp:Label ID="lblQtdeSemana" runat="server" Text="Quantidade Fases: "></asp:Label>
                                </div>
                                <div class="col">
                                    <asp:DropDownList ID="ddlQtdeFases" ForeColor="Red" runat="server" Width="100px"></asp:DropDownList>
                                </div>
                            </div>
                            <!--DIV contendo Label e DropDownList referente a "Duração Fase - (dias)
                                 O DropDown recebe as informações do enumerador em Library/Model/Enuns/DuracaoFaseEnum.cs-->
                            <div class="row" id="row2">
                                <div class="col">
                                    <asp:Label ID="lblDiaFase" runat="server" Text="Duração Fase - (dias): "></asp:Label>
                                </div>
                                <div class="col">
                                    <asp:DropDownList ID="ddlDiaFase" ForeColor="Red" runat="server" Width="100px"></asp:DropDownList>
                                </div>
                            </div>
                            <!--DIV contendo Label e DropDownList referente a "Quantidade Treinos x Dia"
                                 O DropDown recebe as informações do enumerador em Library/Model/Enuns/QtdeTreinosDiaEnum.cs-->
                            <div class="row" id="row3">
                                <div class="col">
                                    <asp:Label ID="lblQtdeTreinos" runat="server" Text="Quantidade Treinos x Dia: "></asp:Label>
                                </div>
                                <div class="col">
                                    <asp:DropDownList ID="ddlQtdeTreinos" ForeColor="Red" runat="server" Width="100px"></asp:DropDownList>
                                </div>
                            </div>
                            <!--DIV contendo Label e DropDownList referente a "Intervalo Treino x Dia"
                                 O DropDown recebe as informações do enumerador em Library/Model/Enuns/IntervaloTreinoEnum.cs-->
                            <div class="row" id="row4">
                                <div class="col">
                                    <asp:Label ID="lblIntervaloTreino" runat="server" Text="Intervalo Treino x Dia: "></asp:Label>
                                </div>
                                <div class="col">
                                    <asp:DropDownList ID="ddlIntervaloTreino" ForeColor="Red" runat="server" Width="100px"></asp:DropDownList>
                                </div>
                            </div>
                            <!--DIV contendo Label e DropDownList referente a "Peso Treino"
                                 O DropDown recebe as informações do enumerador em Library/Model/Enuns/PesoTreinoEnum.cs-->
                            <div class="row" id="row5">
                                <div class="col">
                                    <asp:Label ID="lblPesoTreino" runat="server" Text="Peso Treino: "></asp:Label>
                                </div>
                                <div class="col">
                                    <asp:DropDownList ID="ddlPesoTreino" ForeColor="Red" runat="server" Width="100px"></asp:DropDownList>
                                </div>
                            </div>
                            <!--DIV contendo Label e DropDownList referente a "Peso Desafio"
                                 O DropDown recebe as informações do enumerador em Library/Model/Enuns/PesoDesafioEnum.cs-->
                            <div class="row" id="row6">
                                <div class="col">
                                    <asp:Label ID="lblPesoDesafio" runat="server" Text="Peso Desafio:"></asp:Label>
                                </div>
                                <div class="col">
                                    <asp:DropDownList ID="ddlPesoDesafio" ForeColor="Red" runat="server" Width="100px"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <!--FIM parametros-->
                    </div>
                </div>
                <!--FIM DIV infoExer-->
                <br />

                <div id="observacao">
                    <div id="obsLabel">
                        <asp:Label ID="lblObsClinicas" runat="server" Text="Observações Clínicas:"></asp:Label>
                    </div>
                    <div id="obstext">
                        <asp:TextBox ID="txtObsClinicas" CssClass="txt-obs" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </div>
                </div>
                <!--DIV com os botões: Salvar, Voltar, Estatísticas-->
                <div id="content_bt_tratamento">
                    <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary btn-lg" Width="120px" Text="Salvar" OnClick="btnSalvar_Click" />
                    <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-primary btn-lg" Width="120px" BackColor="#1198ff" Text="Voltar" OnClick="btnVoltar_Click" />
                    <asp:Button ID="btnEstatisticas" runat="server" CssClass="btn btn-primary btn-lg" Width="140px" BackColor="#022d6e" Text="Estatísticas" />
                </div>
            </div>
            <!--FIM DIV content-->
        </div>
    </form>
</body>
</html>
