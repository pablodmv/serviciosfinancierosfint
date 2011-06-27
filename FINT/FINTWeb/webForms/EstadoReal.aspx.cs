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
using System.Collections.Generic;

namespace FINTWeb.webForms
{
    public partial class EstadoReal : System.Web.UI.Page
    {
        int idusuario;
        DataSet dsCuentas = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            String usr = "";
            if (Request.QueryString["usuarioTxt"] != null)
            {
                usr = Request.QueryString["usuarioTxt"];
            }

            idusuario = int.Parse(Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["id"].ToString());
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);

            this.selCuentaCmb.DataSource = dsCuentas.Tables[0];
            if (!Page.IsPostBack)
            {
                this.selCuentaCmb.DataTextField = "Descripcion";
                this.selCuentaCmb.DataValueField = "id";
                this.DataBind();

                this.selCuentaCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
            }


            this.usrLbl.Text = "Bienvenido Usuario: " + usr;
        }

        protected void proyBtn_Click(object sender, EventArgs e)
        {
            int idcuenta = int.Parse(this.selCuentaCmb.SelectedValue.ToString());
            String fecha = this.fechaDtPicker.SelectedDate.ToString("dd/MM/yyyy");
            List<String> source = Controller.getInstancia().estadoCuentaRemoto(idcuenta);
            this.lbEstados.DataSource = source;
            this.DataBind();

            this.selCuentaCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));

        }

        protected void realBtn_Click(object sender, EventArgs e)
        {
            int idcuenta = int.Parse(this.selCuentaCmb.SelectedValue.ToString());
            String fecha = this.fechaDtPicker.SelectedDate.ToString("dd/MM/yyyy");
            List<String> source = Controller.getInstancia().estadoCuentaFINT(idcuenta, fecha);
            this.lbEstados.DataSource = source;
            this.DataBind();

            this.selCuentaCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }
    }
}
