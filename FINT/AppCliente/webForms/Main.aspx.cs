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
using AppCliente.controller;

namespace AppCliente.webForms
{
    public partial class Main : System.Web.UI.Page
    {

        private DataSet dsUsuario = new DataSet();
        private DataSet cuentas = new DataSet();
        private DataSet usuarios = new DataSet();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            usuarios = Controller.getInstancia().obtenerUsuariosXTipo();
            this.cliCmb.DataSource = usuarios.Tables[0];

            if (!Page.IsPostBack)
            {

                this.cliCmb.DataTextField = "Nombre";
                this.cliCmb.DataValueField = "id";
                //this.DataBind();

                this.gridCuentas.DataSource = inicilializedTable();
                this.DataBind();

                this.cliCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));


            }

            this.usrLbl.Text = "Bienvenido Usuario: " + Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["Nombre"];
            
        }

        protected void verCuentasBtn_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(this.cliCmb.SelectedValue);
            //cuentas = Controller.getInstancia().obtenerCuentasXusuario(idUsuario);
            this.gridCuentas.DataSource = this.getResultTable(idUsuario);
            this.DataBind();
            this.cliCmb.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }

        private DataTable inicilializedTable()
        {
            DataTable table = new DataTable();
            
            table.Columns.Add("NoCuenta", typeof(string));

            table.Rows.Add("");
            return table;
        }

        private DataTable getResultTable(int idUsuario)
        {
            cuentas = Controller.getInstancia().obtenerCuentasXusuario(idUsuario);
            DataTable table = new DataTable();
            
            table.Columns.Add("NoCuenta", typeof(string));

            if (cuentas.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < cuentas.Tables[0].Rows.Count; i++)
                {
                    table.Rows.Add(cuentas.Tables[0].Rows[i]["NumeroCuenta"].ToString());
                }
            }
            else
            {
                table.Rows.Add("");
            }
           
            return table;
            
        }

        protected void gridCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String numCuenta = this.gridCuentas.SelectedRow.Cells[1].Text;
            this.noCuentaTxt.Text = numCuenta;

        }

    }
}
