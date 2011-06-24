using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace fint.Forms.fint.controller
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
        public Controller()
        {
            dsusuario = new DataSet();
            dsProveedores = new DataSet();
        }

        public DataSet loginUsuario(String usr, String pwd)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            dsusuario= service.chequearUsuario(usr, pwd);
            return dsusuario;

            ////Codigo provisorio
            //if (usr.Equals("gus") && pwd.Equals("gus"))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

        public static int agregarUsuario(String nombre, String login, String pwd)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            
           return service.agregarUsuario(nombre, login, pwd, serverFINTFachada.rol.Usuario);

            
        }

        public Boolean editarUsuario(String nombre, String pwd, int id)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.modificarUsuario(nombre, pwd,id);

        }

        public DataSet obtenerProveedores()
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            dsProveedores= service.obtenerProveedores();
            return dsProveedores;
        
        }
        public Boolean ingresarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario)
        {
            serverFINTFachada.serverFINTFachada service = new serverFINTFachada.serverFINTFachada();
            return service.ingresarCuenta(numero, descripcion, saldo, idProveedor, idUsuario);
        
        }


        public static Boolean desactivarUsuario(String login)
        {

            return true;
        }

        //Agregar metodo getAllProveedores()

        //Agregar metodo agregarCuenta(int idUsuario, double saldo, String desc, int nCuenta)


        public static Boolean agregarGasto(int nFactura,String concepto, double monto, DateTime venc)
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
