using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace FINTWeb.webForms
{
    public partial class EstadoReal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String usr = "";
            if (Request.QueryString["usuarioTxt"] != null)
            {
                usr = Request.QueryString["usuarioTxt"];
            }
            this.usrLbl.Text = "Bienvenido Usuario: " + usr;
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
