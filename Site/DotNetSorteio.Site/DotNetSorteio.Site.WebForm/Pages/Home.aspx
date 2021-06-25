<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout/Layout.Master" AutoEventWireup="true" Async="true" CodeBehind="Home.aspx.cs" Inherits="DotNetSorteio.Site.WebForm.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="gridSoteio" runat="server" OnItemDataBound="gridSoteio_ItemDataBound">
        <HeaderTemplate>
            <h4>Lista de Sorteios</h4>
            <table class="table col-10">
                <tr>
                    <th scope="col" style="width: 50px">ID</th>
                    <th scope="col" style="width: 100px">Título</th>
                    <th scope="col" style="width: 200px">Descrição</th>
                    <th scope="col" style="width: 80px">Situação</th>
                    <th scope="col" style="width: 80px">Início</th>
                    <th scope="col" style="width: 80px">Fim</th>
                    <th scope="col" style="width: 150px">Ações</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="lblSorteioId" runat="server" Text='<%#  DataBinder.Eval(Container.DataItem, "SorteioId") %>' />
                </td>
                <td>
                    <asp:Label ID="lblTitulo" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Titulo") %>' />
                </td>
                <td>
                    <asp:Label ID="lblDescricao" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Descricao") %>' />
                </td>
                <td>
                    <asp:Label ID="lblSituacao" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Situacao") %>' />
                </td>
                <td>
                    <asp:Label ID="lblInicio" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "DataInicio") %>' />
                </td>
                <td>
                    <asp:Label ID="lblFim" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "DataFim") %>' />
                </td>                
                <td>
                    <asp:Button ID="btnParticipar" runat="server" Text="Participar" CssClass="btn btn-success"
                        CommandArgument='<%#  DataBinder.Eval(Container.DataItem, "SorteioId") %>' visible="false"/>

                    <asp:Button ID="btnDeixar" runat="server" Text="Deixar de Participar" CssClass="btn btn-danger"
                        CommandArgument='<%#  DataBinder.Eval(Container.DataItem, "SorteioId") %>' visible="false"/>
                </td>
            </tr>
            <asp:HiddenField ID="hdfUsuarioId" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "UsuarioId") %>' />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
