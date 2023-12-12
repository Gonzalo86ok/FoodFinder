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
            ListaOutSide = negocio.listarDelivery();
            if (!IsPostBack)
            {
                Repeater1.DataSource = ListaOutSide;
                Repeater1.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioDonde.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string selectedId = btn.CommandArgument;
            Response.Redirect("FormularioDonde.aspx?id=" + selectedId);
        }

        protected void bntEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}