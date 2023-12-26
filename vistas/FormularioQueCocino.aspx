<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FormularioQueCocino.aspx.cs" Inherits="vistas.FormularioQueCocino" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h2>Agregar Receta</h2>

    <div class="row mx-auto mt-5">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label runat="server" ID="lblNombre" Text="Nombre"></asp:Label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label runat="server" ID="lblCategoria" Text="Categoría"></asp:Label>
                <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-select">
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Label runat="server" ID="lblReceta" Text="Receta"></asp:Label>
                <asp:TextBox runat="server" ID="txtReceta" TextMode="MultiLine" Rows="4" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label runat="server" ID="lblDescripcion" Text="Descripción"></asp:Label>
                <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="4" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label runat="server" ID="lblImagen" Text="Imagen"></asp:Label>
                <asp:TextBox ID="txtbImagen" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtbImagen_TextChanged"></asp:TextBox>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" runat="server" ID="img" Width="60%" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="d-grid gap-2">
                <asp:Button runat="server" ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" />
                <asp:Button Text="Cancelar" ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" CssClass="btn btn-danger" />
            </div>
        </div>
    </div>
</asp:Content>


