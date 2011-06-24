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


        private static Controller instancia;
        private DataSet dsusuario;
        private DataSet dsProveedores;

        public DataSet DsProveedores
        {
            get { return dsProveedores; }
            set { dsProveedores = value; }
        }

        public DataSet dsUsuario
        {
            get { return dsusuario; }
            set { dsusuario = value; }
        }

        public static Controller getInstancia()
        {

            if (instancia == null)
            {
                instancia = new Controller();
            }
            return instancia;
        }

        private Controller()
        {
            dsusuario = new DataSet();

        }


        public DataSet loginUsuario(String usr, String pwd)
        {


            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            dsusuario = service.chequearUsuario(usr, pwd);
            return dsusuario;

            //Codigo provisorio
            //if (usr.Equals("gus") && pwd.Equals("gus"))
            //{
              //  return true;
            //}
            //else
            //{
              //  return false;
            //}

        }

        public int agregarUsuario(String nombre, String login, String pwd)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();

            return service.agregarUsuario(nombre, login, pwd, serverFINTFachada.rol.Usuario);

        }

        public Boolean editarUsuario(String nombre, String pwd, int id)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.modificarUsuario(nombre, pwd, id);

        }

        public static Boolean desactivarUsuario(String login)
        {

            return true;
        }

        public DataSet obtenerProveedores()
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            dsProveedores = service.obtenerProveedores();
            return dsProveedores;

        }

        public Boolean ingresarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.ingresarCuenta(numero, descripcion, saldo, idProveedor, idUsuario);

        }


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
