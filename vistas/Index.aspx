<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="vistas.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>esta es la pagina index</h2>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%  foreach (dominio.OutSide outside in ListaOutSide)
            {
        %>
                <div class="col">
                    <div class="card">
                        <img src="<%:outside.imagen.name %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%:outside.name %></h5>
                            <p class="card-text"><%:outside.descripcion %></p>
                        </div>
                    </div>
                </div>

        <%
            }

        %>
    </div>
</asp:Content>
