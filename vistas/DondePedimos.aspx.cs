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
    }
}