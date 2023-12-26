<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FormularioDonde.aspx.cs" Inherits="vistas.FormularioDondeComemos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container mt-5">
        <div class="row">
            <div class="col-6">
                <h2>Agregar Lugar</h2>
                <div class="mb-3">
                    <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtbNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lbDireccion" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="txtbDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion"></asp:Label>
                    <asp:TextBox ID="txtbDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lbBarrio" runat="server" Text="Barrio"></asp:Label>
                    <asp:TextBox ID="txtbBarrio" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lbLocalidad" runat="server" Text="Localidad"></asp:Label>
                    <asp:DropDownList ID="ddlLocalidad" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lbCategoria" runat="server" Text="Categoria"></asp:Label>
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lbDonde" runat="server" Text="Donde"></asp:Label>
                    <asp:DropDownList ID="ddlDonde" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Comer ahi" />
                        <asp:ListItem Text="Take way y comer ahi" />
                    </asp:DropDownList>
                </div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CssClass="btn btn-secondary" />
            </div>

            <div class="col-6">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="mb-3">
                            <asp:Label ID="lbImagen" runat="server" Text="Imagen"></asp:Label>
                            <asp:TextBox ID="txtbImagen" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtbImagen_TextChanged"></asp:TextBox>
                        </div>
                        <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" runat="server" ID="img" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
