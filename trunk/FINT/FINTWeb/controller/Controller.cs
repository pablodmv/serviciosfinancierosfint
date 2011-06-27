﻿using System;
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
        private DataSet dsCuentasXusuario;
        private DataSet dsGastosXusuario;
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public DataSet DsGastosXusuario
        {
            get { return dsGastosXusuario; }
            set { dsGastosXusuario = value; }
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

        public DataSet obtenerCuentasXusuario(int idusuario)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.obtenerCuentaXusuario(idusuario);

        }

        public Boolean ingresarGasto(String numero, String concepto, Decimal monto, String vencimiento, int estado)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            idUsuario = int.Parse(dsUsuario.Tables[0].Rows[0]["id"].ToString());
            return service.ingresarGasto(numero, concepto, monto, vencimiento, estado, IdUsuario);

        }

        //Agregar metodo obtenerGastosXUsuario(int idUsuario)
        //Agregar metodo obtenerCuentasXUsuario(int idUsuario)


        public static Boolean realizarMovimiento(String cuenta, double monto, String concepto, String tTrans)
        {
            return true;

        }







    }
}