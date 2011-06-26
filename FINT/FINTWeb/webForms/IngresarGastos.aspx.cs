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
    public partial class IngresarGastos : System.Web.UI.Page
    {

        private String usrLogueado = "";

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

            String nFac = this.nFacTxt.Text;
            String desc = this.descTxt.Text;
            
            Double tmpMonto = Double.Parse(this.montoTxt.Text);
            Decimal monto = (Decimal)tmpMonto;
            String fVen = this.fVenDPicker.SelectedDate.ToString("dd/MM/yyyy");
            int estado = (int)Estado.Pendiente;

            if (!nFac.Equals("") && !desc.Equals("") && monto > 0)
            {

                if (Controller.getInstancia().ingresarGasto(nFac, desc, monto, fVen, estado))
                {
                    this.msgLbl.Text = "Gasto ingresado con exito.";
                }

                this.clear();
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

        private void clear()
        {
            this.nFacTxt.Text = "";
            this.descTxt.Text = "";
            this.montoTxt.Text = "";
            this.fVenDPicker.SelectedDate = DateTime.Today; 
            
        }

        public enum Estado
        {
            Pendiente,
            Realizada
        }

    }
}
