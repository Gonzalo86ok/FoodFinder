<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QueComemos.aspx.cs" Inherits="vistas.Que_Comemos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>que comemos</h1>
    
    <div class="container">
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="card" style="width: 100%; border-radius: 10px; overflow: hidden; margin: 10px; height: 100%;">
                        <div class="card-body">
                            <h3 class="card-title"><%# Eval("nombre") %></h3>
                        </div>
                       
                        <div class="card-body">
                            <p class="card-text"><%# Eval("descripcion") %></p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>



</asp:Content>
