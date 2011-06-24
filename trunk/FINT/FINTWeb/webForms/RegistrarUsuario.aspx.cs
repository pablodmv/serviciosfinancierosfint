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

namespace FINTWeb.webForms
{
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {

            String nombre = this.nomTxt.Text;
            String login = this.loginTxt.Text;
            String pwd = this.pwdTxt.Text;

            if (!nombre.Equals("") && !login.Equals("") && !pwd.Equals(""))
            {

                this.msgLbl.Visible = false;
                if (Controller.agregarUsuario(nombre, login, pwd))
                {
                    this.msgLbl.Text = "Usuario ingresado con exito";
                    this.msgLbl.Visible = true;

                    this.clear();
                }

            }
            else
            {
                this.msgLbl.Text = "Todos los datos son requeridos.";
                this.msgLbl.Visible=true;
            }







        }

        private void clear()
        {

            this.nomTxt.Text = "";
            this.loginTxt.Text = "";
            this.pwdTxt.Text = "";
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/index.aspx", false);
        }


    }
}
