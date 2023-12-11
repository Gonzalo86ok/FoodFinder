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
            ListaCook = negocio.listarCook();
            if (!IsPostBack)
            {
                Repeater1.DataSource = ListaCook;
                Repeater1.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}