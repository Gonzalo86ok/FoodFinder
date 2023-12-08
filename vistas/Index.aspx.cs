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
    public partial class Index : System.Web.UI.Page
    {
        public List<OutSide> ListaOutSide {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
    }
}