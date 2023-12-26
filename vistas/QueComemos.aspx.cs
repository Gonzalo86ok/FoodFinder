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
    public partial class Que_Comemos : System.Web.UI.Page
    {
        public List<Cooking> ListaCook { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioCook negocio = new NegocioCook();
            Session.Add("listaCocina", negocio.listarCook());           
            if (!IsPostBack)
            {
                Repeater1.DataSource = Session["listaCocina"];
                Repeater1.DataBind();
            }
        }    

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string selectedId = btn.CommandArgument;
            Response.Redirect("FormularioQueCocino.aspx?id=" + selectedId);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void txtbFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Cooking> lista = (List<Cooking>)Session["listaCocina"];
            List<Cooking> listaFiltrada = lista.FindAll(x => x.nombre.ToUpper().Contains(txtbFiltro.Text.ToUpper()));
            Repeater1.DataSource = listaFiltrada;
            Repeater1.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioQueCocino.aspx");
        }
    }
}