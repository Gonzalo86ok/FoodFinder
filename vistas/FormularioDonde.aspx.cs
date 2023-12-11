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
    public partial class FormularioDondeComemos : System.Web.UI.Page
    {
        NegocioLocalidad localidad = new NegocioLocalidad();
        NegocioCategoria categoria = new NegocioCategoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    List<Localidad> listaLocalidad = localidad.listarLocalidad();
                    ddlLocalidad.DataSource = listaLocalidad;
                    ddlLocalidad.DataValueField = "id";
                    ddlLocalidad.DataTextField = "descripcion";
                    ddlLocalidad.DataBind();

                    List<Categoria> listaCategoria = categoria.listarCategoria();
                    ddlCategoria.DataSource = listaCategoria;
                    ddlCategoria.DataValueField = "id";
                    ddlCategoria.DataTextField = "nombre";
                    ddlCategoria.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtbDireccion.Text) ||
                   string.IsNullOrWhiteSpace(txtbDescripcion.Text) ||
                   string.IsNullOrWhiteSpace(txtbBarrio.Text) ||
                   string.IsNullOrWhiteSpace(txtbImagen.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "showAlert", "alert('Todos los campos deben ser completados');", true);
                    return;
                }

                OutSide nuevo = new OutSide();
                Imagen imagen = new Imagen();
                NegocioComerAfuera negocio = new NegocioComerAfuera();
                NegocioImagen negocioImagen = new NegocioImagen();

                nuevo.name = txtbNombre.Text;
                nuevo.adress = txtbDireccion.Text;
                nuevo.descripcion = txtbDescripcion.Text;
                nuevo.barrio = txtbBarrio.Text;


                nuevo.localidad = new Localidad();
                nuevo.localidad.id = int.Parse(ddlLocalidad.SelectedValue);

                nuevo.categoria = new Categoria();
                nuevo.categoria.id = int.Parse(ddlCategoria.SelectedValue);

                if(ddlDonde.SelectedValue == "Comer ahi")
                {
                    nuevo.outside = 1;
                }
                else
                {
                    nuevo.outside = 3;
                }

                negocio.addOut(nuevo);
               
                imagen.Id_Food = negocio.ultimoID();
                imagen.name = txtbImagen.Text;

                negocioImagen.addImagen(imagen);

                Response.Redirect("DondeComemos.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DondeComemos.aspx", false);
        }
        protected void txtbImagen_TextChanged(object sender, EventArgs e)
        {
            img.ImageUrl = txtbImagen.Text;
        }
    }
}