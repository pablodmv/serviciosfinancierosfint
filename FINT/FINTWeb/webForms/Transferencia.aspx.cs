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
    public partial class Transferencia : System.Web.UI.Page
    {
        private String usrLogueado = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["usuarioTxt"] != null)
            {
                this.usrLogueado = Request.QueryString["usuarioTxt"];
            }
            this.usrLbl.Text = "Bienvenido Usuario: " + this.usrLogueado;

        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }
    }
}
