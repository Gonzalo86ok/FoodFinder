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
        public List<OutSide> ListaNegocio {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
           // dgvOutSide.DataSource = negocio.listarConSP();
         //   dgvOutSide.DataBind();
            //ListaNegocio = negocio.listarOutSide(1);

            //Repeater1.DataSource = ListaNegocio;
            //Repeater1.DataBind();
        }
    }
}