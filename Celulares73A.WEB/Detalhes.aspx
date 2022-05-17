<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Celulares73A.WEB.Detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Comprar Aparelho</h1>

    <table style="width: 91%; height: 25px">
        <tr>
            <td style="width: 150px; height:13px;">
                Modelo:
            </td>
            <td align="left" style="width: 644px; height:13px;" id="lblModelo_">
                <asp.Label ID="lblModelo" runat="server" Text="Label"></asp.Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height:12px;">
                Fabricante:
            </td>
            <td align="left" style="width: 644px; height:13px;" id="lblFabricante_">
                <asp.Label ID="lblFabricante" runat="server" Text="Label"></asp.Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height:12px;">
                Dimensões:
            </td>
            <td align="left" style="width: 644px; height:13px;" id="lblDimensions_">
                <asp.Label ID="lblDimensions" runat="server" Text="Label"></asp.Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height:11px;">
                Quantidade em Estoque:
            </td>
            <td align="left" style="width: 644px; height:13px;" id="lblQuantidadeEstoque_">
                <asp.Label ID="lblQuantidadeEstoque" runat="server" Text="Label"></asp.Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height:12px;">
                Preço:
            </td>
            <td align="left" style="width: 644px; height:12px;">
                <asp.Label ID="lblPreco" runat="server" Text="Label"></asp.Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height:12px;">
                Desconto:
            </td>
            <td align="left" style="width: 644px; height:12px;">
                <asp.Label ID="lblDesconto" runat="server" Text="Label"></asp.Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height:12px;">
            </td>
            <td align="left" style="width: 644px; height:12px;">
                <asp.Button ID="btnComprar" runat="server" Text="Comprar" Width="170px"></asp.Button>
            </td>
        </tr>
    </table>

</asp:Content>
