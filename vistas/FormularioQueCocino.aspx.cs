using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace vistas
{
    public partial class FormularioQueCocino : System.Web.UI.Page
    {
        NegocioCategoriaCook categoria = new NegocioCategoriaCook();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
                {
                    List<Categoria> listaCategoria = categoria.listarCategoriaCook();
                    ddlCategoria.DataSource = listaCategoria;
                    ddlCategoria.DataValueField = "id";
                    ddlCategoria.DataTextField = "nombre";
                    ddlCategoria.DataBind();
                }
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    if (int.TryParse(Request.QueryString["id"], out int id))
                    {
                        NegocioCook negocio = new NegocioCook();
                        Cooking cook = negocio.buscarID(id);
                        NegocioImagen negocioImagen = new NegocioImagen();
                        Imagen imagen = negocioImagen.buscarID(id);

                        txtNombre.Text = cook.nombre;                        
                        txtReceta.Text = cook.receta;
                        txtDescripcion.Text = cook.descripcion;
                       
                        ddlCategoria.SelectedValue = cook.categoria.id.ToString();
                       
                        txtbImagen.Text = imagen.name;

                        txtbImagen_TextChanged(sender, e);
                    }
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
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||                   
                   string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                   string.IsNullOrWhiteSpace(txtReceta.Text) ||
                   string.IsNullOrWhiteSpace(txtbImagen.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "showAlert", "alert('Todos los campos deben ser completados');", true);
                    return;
                }

                Cooking nuevo = new Cooking();
                Imagen imagen = new Imagen();
                NegocioCook negocio = new NegocioCook();
                NegocioImagen negocioImagen = new NegocioImagen();

                nuevo.nombre = txtNombre.Text;
                nuevo.receta = txtReceta.Text;
                nuevo.descripcion = txtDescripcion.Text;               

                nuevo.categoria = new Categoria();
                nuevo.categoria.id = int.Parse(ddlCategoria.SelectedValue);
               
                imagen.name = txtbImagen.Text;

                if (Request.QueryString["id"] != null)
                {
                    nuevo.id = Convert.ToInt32(Request.QueryString["id"]);
                    negocio.modificar(nuevo);
                    imagen.Id_Food = Convert.ToInt32(Request.QueryString["id"]);
                    negocioImagen.modificarImagen(imagen);
                }
                else
                {
                    negocio.addCook(nuevo);
                    imagen.Id_Food = negocio.ultimoID();
                    negocioImagen.addImagen(imagen);
                }
                Response.Redirect("QueComemos.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueComemos.aspx", false);
        }

        protected void txtbImagen_TextChanged(object sender, EventArgs e)
        {
            img.ImageUrl = txtbImagen.Text;
        }
    }
}