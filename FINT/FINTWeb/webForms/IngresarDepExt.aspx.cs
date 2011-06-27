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
        private DataSet dsCuentas = new DataSet();
        int idusuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["usuarioTxt"] != null)
            {
                this.usrLogueado = Request.QueryString["usuarioTxt"];
            }

            idusuario = int.Parse(Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["id"].ToString());
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);

            if (!Page.IsPostBack)
            {
                this.listCuentaCmb.DataSource = dsCuentas.Tables[0];
                this.listCuentaCmb.DataTextField = "Descripcion";
                this.listCuentaCmb.DataValueField = "id";
                
                this.DataBind();

                this.listCuentaCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));

            }

            this.usrLbl.Text = "Bienvenido Usuario: " + this.usrLogueado;
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Boolean resultado = false;
                Double monto = Double.Parse(this.montoTxt.Text);
                String conc = this.descTxt.Text;
                int cuenta = int.Parse(this.listCuentaCmb.SelectedValue.ToString());

                if (!monto.Equals("") && !conc.Equals("") && !cuenta.Equals(""))
                {

                    if (this.tipoTrans.Equals("Deposito"))
                    {
                        resultado = Controller.getInstancia().realizarDeposito(cuenta, (Decimal)monto, conc);

                    }
                    else
                    {
                        resultado = Controller.getInstancia().realizarExtraccion(cuenta, (Decimal)monto, conc);
                    }

                    if (resultado)
                    {
                        this.msgLbl.Text = "Transacción realizada con exito.";
                    }
                    else
                    {
                        this.msgLbl.Text = "Error en la transaccion.";
                    }


                }
                else
                {
                    this.msgLbl.Text = "Todos los datos son requeridos.";
                }


            }
            catch (Exception ex)
            {
                this.msgLbl.Text = "Monto incorrecto";
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
