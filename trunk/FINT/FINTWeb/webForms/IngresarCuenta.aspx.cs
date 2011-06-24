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
using FINTWeb.controller;

namespace FINTWeb.webForms
{
    public partial class IngresarCuenta : System.Web.UI.Page
    {
        private DataSet proveedores = new DataSet();
        private String usrLogueado = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            proveedores = Controller.getInstancia().obtenerProveedores();
            this.provCmb.DataSource = proveedores.Tables[0];
            //this.provCmb.Items.Clear();

            if(!Page.IsPostBack){
                this.provCmb.DataTextField = "Nombre";
                this.provCmb.DataValueField = "id";
                this.DataBind();

                this.provCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
            }
            

            if (Request.QueryString["usuarioTxt"] != null)
            {
                this.usrLogueado = Request.QueryString["usuarioTxt"];
            }
            this.usrLbl.Text = "Bienvenido Usuario: " + this.usrLogueado;

        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {
            String noCuenta = this.noCuentaTxt.Text;
            //this.noCuentaValidator(noCuenta);
            String descripcion = this.descTxt.Text;
            Decimal saldo = Decimal.Parse(this.saldoTxt.Text);
            int idProveedor = int.Parse(this.provCmb.SelectedValue);
            int idUsuario = int.Parse(Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["id"].ToString());

            if (!noCuenta.Equals("") && saldo != 0)
            {

                this.msgLbl.Visible = false;

                if (Controller.getInstancia().ingresarCuenta(noCuenta, descripcion, saldo, idProveedor, idUsuario))
                {
                    this.msgLbl.Text = "Cuenta ingresada con exito";
                    this.msgLbl.Visible = true;
                }
                else
                {
                    this.msgLbl.Text = "Error al ingresar el Cuenta. Consulte";
                    this.msgLbl.Visible = true;
                }

            }
            else
            {
                this.msgLbl.Visible = true;
            }

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
