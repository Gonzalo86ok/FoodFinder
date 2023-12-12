<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DondePedimos.aspx.cs" Inherits="vistas.QuePedimos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Donde Pedimos</h1>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    <div class="container">
        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-md-4">
                        <div class="card" style="width: 100%; border-radius: 10px; overflow: hidden; margin: 10px; height: 100%;">
                            <div class="card-body">
                                <h3 class="card-title"><%# Eval("name") %></h3>
                            </div>
                            <img src="<%# Eval("Imagen.name")%>" class="card-img-top" alt="..." style="width: 100%; border-radius: 10px 10px 0 0;">
                            <div class="card-body">
                                <p class="card-text"><%# Eval("descripcion") %></p>
                            </div>
                            <div class="btn-group">
                                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" CommandArgument='<%# Eval("Id") %>'/>
                                <asp:Button ID="bntEliminar" runat="server" Text="Eliminar" OnClick="bntEliminar_Click" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
