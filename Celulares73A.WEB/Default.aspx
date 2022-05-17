<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Celulares73A.WEB._Default" %>

<%@ Import Namespace="Celulares73A.Model.Entidades" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Listagem de Aparelhos</h1>

    <table style="width: 91%; height: 156px;">
            <% foreach (Aparelho ap in aparelhos)   { %>
            <tr>
                <td style="width: 197px; height: 125px;">
                    <img src="imagens/icone.jpg" style="height: 134px; width: 132px; margin-left: 3em;" /></td>
                <td align="left" style="width: 644px; height: 125px;">
                    <b style="font-size:20px"><%=ap.Fabricante.Nome + " " + ap.Modelo %></b><br />
                    <b style="font-size:24px"><%=ap.Preco.ToString("C") %></b><br />
                    <i style="font-size:20px"><%=ap.Quantidade %> em estoque</i><br />
                    <b style="font-size:20px"><a href="Detalhes.aspx?aparelho=<%=ap.Id_Aparelho %>">Mais detalhes</a></b>
                </td>
            </tr>
            <% } %>
        </table>

</asp:Content>
