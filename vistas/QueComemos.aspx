<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QueComemos.aspx.cs" Inherits="vistas.Que_Comemos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>que comemos</h1>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="md-3">
                    <asp:Label Text="Filtro" runat="server" />
                    <asp:TextBox runat="server" ID="txtbFiltro" AutoPostBack="true" OnTextChanged="txtbFiltro_TextChanged" CssClass="form-control" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="md-3">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" />
                    <div class="mb-2"></div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4">
                            <div class="card" style="width: 100%; border-radius: 10px; overflow: hidden; margin: 10px; height: 100%;">
                                <div class="card-body">
                                    <h3 class="card-title">
                                        <a href='<%# "DetalleComida.aspx?id=" + Eval("Id") %>' style="color: black; text-decoration: none;"><%# Eval("Nombre") %></a>
                                    </h3>
                                </div>
                                <a href='<%# "DetalleComida.aspx?id=" + Eval("Id") %>'>
                                    <img src="<%# Eval("Imagen.name")%>" class="card-img-top" alt="..." style="width: 100%; height: 200px; border-radius: 10px 10px 0 0; object-fit: cover;">
                                </a>
                                <div class="card-body">
                                    <p class="card-text"><%# Eval("descripcion") %></p>
                                </div>
                                <div class="card-body">
                                    <p class="card-text"><%# Eval("receta") %></p>
                                </div>
                                <div class="btn-group">
                                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" CommandArgument='<%# Eval("Id") %>'/>
                                    &nbsp;
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
