<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DondeComemos.aspx.cs" Inherits="vistas.DondeComemos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Donde Comemos</h1>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

            <asp:GridView ID="dgvOutSide" runat="server" CssClass="table"></asp:GridView>

        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
