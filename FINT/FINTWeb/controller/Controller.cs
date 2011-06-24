using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace FINTWeb.controller
{
    public class Controller
    {

        public static Boolean loginUsuario(String usr, String pwd)
        {

            //Codigo provisorio
            if (usr.Equals("gus") && pwd.Equals("gus"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean agregarUsuario(String nombre, String login, String pwd)
        {
            return true;

        }

        public static Boolean editarUsuario(String nombre, String pwd)
        {
            return true;

        }

        public static Boolean desactivarUsuario(String login)
        {

            return true;
        }

        //Agregar metodo getAllProveedores()

        //Agregar metodo agregarCuenta(int idUsuario, double saldo, String desc, int nCuenta)


        public static Boolean agregarGasto(int nFactura, String concepto, double monto, DateTime venc)
        {

            return true;
        }


        //Agregar metodo obtenerGastosXUsuario(int idUsuario)
        //Agregar metodo obtenerCuentasXUsuario(int idUsuario)


        public static Boolean realizarMovimiento(String cuenta, double monto, String concepto, String tTrans)
        {
            return true;

        }







    }
}
