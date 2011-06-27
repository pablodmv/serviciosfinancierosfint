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
    public partial class Transferencia : System.Web.UI.Page
    {
        private String usrLogueado = "";
        private DataSet dsCuentas = new DataSet();
        private DataSet dsCuentas2 = new DataSet();
        int idusuario;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["usuarioTxt"] != null)
            {
                this.usrLogueado = Request.QueryString["usuarioTxt"];
            }

            idusuario = int.Parse(Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["id"].ToString());
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
            dsCuentas2 = Controller.getInstancia().obtenerCuentasXusuario(idusuario);

            if (!Page.IsPostBack)
            {

                this.cuentaIniCmb.DataSource = dsCuentas.Tables[0];
                this.cuentaIniCmb.DataTextField = "Descripcion";
                this.cuentaIniCmb.DataValueField = "id";

                this.cuentaFinCmb.DataSource = dsCuentas.Tables[0];
                this.cuentaFinCmb.DataTextField = "Descripcion";
                this.cuentaFinCmb.DataValueField = "id";
                this.DataBind();

                this.cuentaIniCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
                this.cuentaFinCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
            }

            this.usrLbl.Text = "Bienvenido Usuario: " + this.usrLogueado;

        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {
            Double tmpmonto = Double.Parse(this.montoTxt.Text);
            Decimal monto = (Decimal)tmpmonto;
            String concepto = this.descTxt.Text;
            int cuentaini = int.Parse(this.cuentaIniCmb.SelectedValue.ToString());
            int cuentafin = int.Parse(this.cuentaFinCmb.SelectedValue.ToString());
            Boolean result = Controller.getInstancia().realizarTransferencia(cuentaini, cuentafin, monto, concepto);
            if (result)
            {
                this.msgLbl.Text = "Transferencia realizada con exito.";
            }
            else
            {
                this.msgLbl.Text = "error";
            }


        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }
    }
}
