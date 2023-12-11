<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FormularioTakeWay.aspx.cs" Inherits="vistas.FormularioTakeWay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

 <div class="row mx-auto mt-5">
     <div class="col-6">
         <div class="mb-3">
             <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
             <asp:TextBox ID="txtbNombre" runat="server"></asp:TextBox>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbDireccion" runat="server" Text="Direccion"></asp:Label>
             <asp:TextBox ID="txtbDireccion" runat="server"></asp:TextBox>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion"></asp:Label>
             <asp:TextBox ID="txtbDescripcion" runat="server"></asp:TextBox>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbBarrio" runat="server" Text="Barrio"></asp:Label>
             <asp:TextBox ID="txtbBarrio" runat="server"></asp:TextBox>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbLocalidad" runat="server" Text="Localidad"></asp:Label>
             <asp:DropDownList ID="ddlLocalidad" runat="server" CssClass="btn btn-outline-dark dropdown-toggle"></asp:DropDownList>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbCategoria" runat="server" Text="Categoria"></asp:Label>
             <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
         </div>
         <asp:Label ID="lbDonde" runat="server" Text="Donde"></asp:Label>
         <asp:DropDownList ID="ddlDonde" runat="server" CssClass="btn btn-outline-dark dropdown-toggle">
             <asp:ListItem Text="Take way" />
             <asp:ListItem Text="Take way y comer ahi" />
         </asp:DropDownList>
     </div>




     <div class="col-6">
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
                 <div class="mb-3">
                     <asp:Label ID="lbImagen" runat="server" Text="Imagen"></asp:Label>
                     <asp:TextBox ID="txtbImagen" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtbImagen_TextChanged"></asp:TextBox>
                 </div>
                 <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" runat="server" ID="img" Width="60%" />
             </ContentTemplate>
         </asp:UpdatePanel>           
             <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
         
     </div>
 </div>
</asp:Content>
