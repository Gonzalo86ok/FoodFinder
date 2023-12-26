using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vistas
{
    public partial class DetalleDelivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                negocioDelivery negocio = new negocioDelivery();
                OutSide outSide = negocio.buscarID(id);
                NegocioImagen negocioImagen = new NegocioImagen();
                Imagen imagen = negocioImagen.buscarID(id);

                Label1.Text = outSide.name;
                Label2.Text = outSide.adress;
                Label3.Text = outSide.descripcion;
                Label4.Text = outSide.barrio;
                Label5.Text = outSide.localidad.descripcion;
                Label6.Text = outSide.categoria.nombre;
                img.ImageUrl = imagen.name;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DondePedimos.aspx", false);
        }
    }
}