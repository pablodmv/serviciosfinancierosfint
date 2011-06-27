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
using AppCliente.serverFINTFachada;

namespace AppCliente.controller
{
    public class Controller
    {

        private static Controller instancia;
        private DataSet dsusuario;
        private DataSet dsProveedores;
        private DataSet dsCuentasXusuario;
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public DataSet DsCuentasXusuario
        {
            get { return dsCuentasXusuario; }
            set { dsCuentasXusuario = value; }
        }

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
            dsProveedores = new DataSet();
        }

        public DataSet loginUsuario(String usr, String pwd)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            dsusuario = service.chequearUsuario(usr, pwd);
            if (dsUsuario.Tables[0].Rows.Count > 0)
            {
                IdUsuario = int.Parse(dsUsuario.Tables[0].Rows[0]["id"].ToString());
            }
            return dsusuario;

        }

        public DataSet obtenerCuentasXusuario(int idusuario)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.obtenerCuentaXusuario(idusuario);

        }

        public DataSet obtenerUsuariosXTipo()
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            
            //Para este caso solo nos interesa traer todos los usuarios con rol
            //Usuario.
            return service.obtenerUsuariosXTipo(rol.Usuario);
        }

        public Boolean ingresarComprobante(int idcuenta, Decimal monto, String numcomprobante, int idcliente)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.ingresarComprobante(idcuenta, monto, numcomprobante, idcliente);

        }



    }
}
