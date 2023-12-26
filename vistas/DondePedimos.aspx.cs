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
    public partial class QuePedimos : System.Web.UI.Page
    {
        public List<OutSide> ListaOutSide { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            negocioDelivery negocio = new negocioDelivery();
            Session.Add("listaLocales", negocio.listarDelivery());
            if (!IsPostBack)
            {
                Repeater1.DataSource = Session["listaLocales"];
                Repeater1.DataBind();
            }                      
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioTakeWay.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string selectedId = btn.CommandArgument;
            Response.Redirect("FormularioTakeWay.aspx?id=" + selectedId);
        }

        protected void bntEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void txtbFiltro_TextChanged(object sender, EventArgs e)
        {
            List<OutSide> lista = (List<OutSide>)Session["listaLocales"];
            List<OutSide> listaFiltrada = lista.FindAll(x => x.barrio.ToUpper().Contains(txtbFiltro.Text.ToUpper()) || x.name.ToUpper().Contains(txtbFiltro.Text.ToUpper()));
            Repeater1.DataSource = listaFiltrada;
            Repeater1.DataBind();
        }
    }
}