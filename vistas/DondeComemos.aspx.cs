using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace vistas
{
    public partial class DondeComemos : System.Web.UI.Page
    {
        public List<OutSide> ListaOutSide { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioComerAfuera negocio = new NegocioComerAfuera();
            ListaOutSide = negocio.listarOutSide();
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

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}