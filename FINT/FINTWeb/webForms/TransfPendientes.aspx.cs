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
    public partial class TransfPendientes : System.Web.UI.Page
    {

        DataSet dsTransacciones = new DataSet();
        private String usrLogueado = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            dsTransacciones = Controller.getInstancia().obtenerTransaccionesPendientes();
            dsTransacciones.Tables[0].Columns.Add("Display", typeof(string), "Concepto + ' Total: ' + Monto + ' Fecha: '+ Fecha");



            if (Request.QueryString["usuarioTxt"] != null)
            {
                this.usrLogueado = Request.QueryString["usuarioTxt"];
            }

            if (!Page.IsPostBack)
            {
                cargar();
            }
            
            this.usrLbl.Text = "Bienvenido Usuario: " + this.usrLogueado;
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {
            int idtransac = int.Parse(this.transLb.SelectedValue.ToString());
            if (Controller.getInstancia().confirmarComprobante(idtransac))
            {
                this.msgLbl.Text = "Transaccion realizada con exito";
                borrarseleccionado(idtransac);
                cargar();
            }
            else
            {
                this.msgLbl.Text = "Error";
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }

        private void borrarseleccionado(int idTransac)
        {
            for (int i = 0; i < dsTransacciones.Tables[0].Rows.Count; i++)
            {
                if (dsTransacciones.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (int.Parse(dsTransacciones.Tables[0].Rows[i]["NumTransac"].ToString()) == idTransac)
                    {
                        dsTransacciones.Tables[0].Rows[i].Delete();
                    }
                }
            }
        }

        private void cargar()
        {

            this.transLb.DataSource = dsTransacciones.Tables[0];
            this.transLb.DataTextField = "Display";
            this.transLb.DataValueField = "NumTransac";
            this.DataBind();
        }

    }
}
