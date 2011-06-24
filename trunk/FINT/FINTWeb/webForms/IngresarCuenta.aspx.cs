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
using System.Text.RegularExpressions;

namespace FINTWeb.webForms
{
    public partial class IngresarCuenta : System.Web.UI.Page
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
            String noCuenta = this.noCuentaTxt.Text;
            this.noCuentaValidator(noCuenta);
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }

        private Boolean noCuentaValidator(String numCuenta)
        {
            String pattern = "^\\d{5}";
            Regex myReg = new Regex(pattern,RegexOptions.IgnoreCase);

            if (myReg.IsMatch(numCuenta))
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
