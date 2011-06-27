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

namespace FINTWeb.webForms
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String usr = "";
            if (Request.QueryString["usuarioTxt"] !=null)
            {
                usr = Request.QueryString["usuarioTxt"];
            }

            if(!usr.Equals("")){
                this.usrLbl.Text = "Bienvenido Usuario: " + usr;

                MenuItem mIEditar = this.Menu1.FindItem("DatosPersonales/Editar");
                mIEditar.NavigateUrl = "~/webForms/EditarUsuario.aspx?usuarioTxt=" + usr;

                MenuItem mIDes = this.Menu1.FindItem("DatosPersonales/Desactivar");
                mIDes.NavigateUrl = "~/webForms/EliminarUsuario.aspx?usuarioTxt=" + usr;

                MenuItem mICuentas = this.Menu1.FindItem("Cuentas/NuevaCuenta");
                mICuentas.NavigateUrl = "~/webForms/IngresarCuenta.aspx?usuarioTxt=" + usr;

                MenuItem mIGastos = this.Menu1.FindItem("Acciones/Gastos");
                mIGastos.NavigateUrl = "~/webForms/IngresarGastos.aspx?usuarioTxt=" + usr;

                MenuItem mIPagos = this.Menu1.FindItem("Acciones/Pagos");
                mIPagos.NavigateUrl = "~/webForms/IngresarPagos.aspx?usuarioTxt=" + usr;

                MenuItem mIDepExt = this.Menu1.FindItem("Acciones/DepExtr");
                mIDepExt.NavigateUrl = "~/webForms/IngresarDepExt.aspx?usuarioTxt=" + usr;

                MenuItem mITrans = this.Menu1.FindItem("Acciones/Transferencias");
                mITrans.NavigateUrl = "~/webForms/Transferencia.aspx?usuarioTxt=" + usr;

                MenuItem mITransPend = this.Menu1.FindItem("Acciones/TransfPendientes");
                mITransPend.NavigateUrl = "~/webForms/TransfPendientes.aspx?usuarioTxt=" + usr;

                MenuItem mIReal = this.Menu1.FindItem("EstadoCuentas/Real");
                mIReal.NavigateUrl = "~/webForms/EstadoReal.aspx?usuarioTxt=" + usr;


            }

            




        }
    }
}
