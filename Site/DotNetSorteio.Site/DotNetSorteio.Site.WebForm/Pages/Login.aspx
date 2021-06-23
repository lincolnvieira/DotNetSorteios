<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout/Layout.Master" AutoEventWireup="true" Async="true" CodeBehind="Login.aspx.cs" Inherits="DotNetSorteio.Site.WebForm.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container h-100">
        <div class="row align-items-center h-100">
            <div class="col-6 mx-auto">
                <%--<center>--%>
                <div class="jumbotron h-100" style="background: #ffffff; position: relative; top: 20px; border-radius: 50px;">
                    <%--Título.--%>
                    <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                        <center style="color: #000521">
                            <h1 style="font-size: 24px">Olá, Seja Bem-Vindo</h1>
                        </center>
                    </div>
                    <br>
                    <%--Formulário.--%>
                    <div class="row" style="color: #ffffff">
                        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="E-mail"></asp:TextBox>
                            <%--<asp:RegularExpressionValidator
                                ID="RegularExpressionValidator1"
                                runat="server"
                                ErrorMessage="E-mail inválido"
                                Display="Dynamic"
                                ControlToValidate="txtEmail"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ForeColor="Red">
                            </asp:RegularExpressionValidator>--%>
                        </div>
                    </div>
                    <br />
                    <div class="row" style="color: #ffffff">
                        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                            <asp:TextBox ID="txtSenha" runat="server" class="form-control" placeholder="Senha"></asp:TextBox>
                            <%--<asp:RegularExpressionValidator
                                ID="RegularExpressionValidator2"
                                runat="server"
                                ErrorMessage="Senha inválida"
                                Display="Dynamic"
                                ControlToValidate="txtSenha"
                                ValidationExpression="^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$"
                                ForeColor="Red">
                            </asp:RegularExpressionValidator>--%>
                        </div>
                    </div>
                    <asp:Label ID="respostaLabel" runat="server" Text="" CssClass="alert-danger"></asp:Label>
                    <br />
                    <div class="row">
                        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                            <center>
                                <asp:Button Style="width: 30%; background: #000521; border-color: #000521" ID="btnLogin" runat="server" Text="Entrar" class="btn btn-primary" OnClick="btnLogin_Click" />
                            </center>
                        </div>
                    </div>
                    <br />
                    <center>
                        <div class="row">
                            <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                                <asp:LinkButton ID="esqueceuSenhaLinkButton" Style="color: #0073b1" runat="server">Esqueceu a senha?</asp:LinkButton>
                            </div>
                        </div>
                        <p>
                            <div class="row">
                                <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                                    <label style="color: #000000">Ainda não possui cadastro?</label>&nbsp&nbsp<asp:LinkButton ID="btnCadastrar" Style="color: #0073b1" runat="server" OnClick="btnCadastrar_Click">Cadastre-se</asp:LinkButton>
                                </div>
                            </div>
                    </center>
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
