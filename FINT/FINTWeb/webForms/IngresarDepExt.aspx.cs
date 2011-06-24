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
    public partial class IngresarDepExt : System.Web.UI.Page
    {

        private String usrLogueado = "";
        private String tipoTrans = "";

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

            String monto = this.montoTxt.Text;
            String conc = this.descTxt.Text;
            String cuenta = this.listCuentaCmb.SelectedValue;

            

            if (!monto.Equals("") && !conc.Equals("") && !cuenta.Equals(""))
            {

                if (Controller.realizarMovimiento(cuenta, double.Parse(monto), conc, tipoTrans))
                {
                    this.msgLbl.Text = "Transacción realizada con exito.";
                }

            }
            else
            {
                this.msgLbl.Text = "Todos los datos son requeridos.";
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoTrans = this.RadioButtonList1.SelectedValue;
            
        }
    }
}
