<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalleDelivery.aspx.cs" Inherits="vistas.DetalleDelivery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalles delivery</h1>
     <div class="row mx-auto mt-5">
     <div class="col-6">
         <div class="mb-3">
             <asp:Label ID="lbNombre" runat="server" Text="Nombre: "></asp:Label>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbDireccion" runat="server" Text="Direccion: "></asp:Label>
             <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion: "></asp:Label>
             <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbBarrio" runat="server" Text="Barrio: "></asp:Label>
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbLocalidad" runat="server" Text="Localidad: "></asp:Label>
             <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
         </div>
         <div class="mb-3">
             <asp:Label ID="lbCategoria" runat="server" Text="Categoria: "></asp:Label>
             <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
         </div>           
     </div>
     <div class="col-6">
         <contenttemplate>
             <div class="mb-3">
                 <asp:Label ID="lbImagen" runat="server" Text="Imagen"></asp:Label>                
             </div>
             <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" runat="server" ID="img" Width="60%" />
         </contenttemplate>

         <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
     </div>
 </div>
</asp:Content>
