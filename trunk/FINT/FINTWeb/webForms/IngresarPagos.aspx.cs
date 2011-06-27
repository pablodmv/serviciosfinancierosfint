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
    public partial class IngresarPagos : System.Web.UI.Page
    {
        private DataSet dsGastos = new DataSet();
        private DataSet dsCuentas = new DataSet();
        int idusuario;
        private String usrLogueado = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["usuarioTxt"] != null)
            {
                this.usrLogueado = Request.QueryString["usuarioTxt"];
            }


            idusuario = int.Parse(Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["id"].ToString());
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
            dsGastos = Controller.getInstancia().obtenerGastosXusuario(idusuario);
            dsGastos.Tables[0].Columns.Add("Display", typeof(string), "Concepto + ' Total: ' + Monto");

            if (!Page.IsPostBack)
            {
                this.selCuentaCmb.DataSource = dsCuentas.Tables[0];
                this.selCuentaCmb.DataTextField = "Descripcion";
                this.selCuentaCmb.DataValueField = "id";
                cargarPagos();
                this.DataBind();

                this.selCuentaCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
                
            }

            this.usrLbl.Text = "Bienvenido Usuario: " + this.usrLogueado;
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idGasto = int.Parse(this.gastoLb.SelectedValue.ToString());
                int idCuenta = int.Parse(this.selCuentaCmb.SelectedValue.ToString());
                if (Controller.getInstancia().realizarPago(idGasto, idCuenta))
                {
                    this.msgLbl.Text = "Pago Realizado con exito";
                    borrarseleccionado(idGasto);
                    cargarPagos();
                    this.DataBind();
                    //this.selCuentaCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
                    //  this.msgLbl.Text = "";

                }
                else
                {
                    this.msgLbl.Text = "Ocurrio un error al realizar el pago";
                }
            }
            catch (Exception)
            {

                this.msgLbl.Text = "ERROR";
            }





        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }


        private void borrarseleccionado(int idGasto)
        {
            for (int i = 0; i < dsGastos.Tables[0].Rows.Count; i++)
            {
                if (dsGastos.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (int.Parse(dsGastos.Tables[0].Rows[i]["id"].ToString()) == idGasto)
                    {
                        dsGastos.Tables[0].Rows[i].Delete();
                    }
                }
            }
           
        }


        public void cargarPagos()
        {
            
            this.gastoLb.DataSource = dsGastos.Tables[0];
            this.gastoLb.DataTextField = "Display";
            this.gastoLb.DataValueField = "id";
            
        }
    }
}
