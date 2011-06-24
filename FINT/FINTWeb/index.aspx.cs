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
using FINTWeb.controller;

namespace FINTWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {

            String usr = this.usuarioTxt.Text;
            String pwd = this.pwdTxt.Text;

            if (Controller.loginUsuario(usr, pwd))
            {
                
                Server.Transfer("~/webForms/Main.aspx",true);

            }
            else
            {
                this.msgLbl.Visible = true;

            }






        }
    }
}
