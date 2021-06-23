<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout/Layout.Master" AutoEventWireup="true" Async="true" CodeBehind="Cadastro.aspx.cs" Inherits="DotNetSorteio.Site.WebForm.Pages.Layout.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container h-100">
        <div class="row align-items-center h-100">
            <div class="col-6 mx-auto">
                <div class="jumbotron h-100" style="background: #ffffff; position: relative; top: 20px; border-radius: 50px;">
                    <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                        <center style="color: #000521">
                            <h1 style="font-size: 24px">Cadastro</h1>
                        </center>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label1" runat="server" Text="Nome" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label2" runat="server" Text="E-mail" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label3" runat="server" Text="Senha" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label4" runat="server" Text="CEP" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtCEP" runat="server" CssClass="form-control" OnTextChanged="txtCEP_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label5" runat="server" Text="Endereço" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" ReadOnly="true" Enabled="false"></asp:TextBox>
                    </div>
                    <center>
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-primary" Style="width: 30%; background: #000521; border-color: #000521" OnClick="btnCadastrar_Click" />
                    </center>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
