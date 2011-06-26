using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;
using System.Data;


namespace serverFINT
{



    public class Sistema
    {
        private static Sistema instancia = null;
        private List<Usuario> colusuarios = new List<Usuario>();
        private List<Proveedor> colProveedor =new List<Proveedor>();
        private List<Gasto> colGasto = new List<Gasto>();

       


        private Sistema() { }


        public static Sistema getInstancia()
        {

            if (instancia==null)
            {
                instancia= new Sistema();
            }
            return instancia;
        }

        public List<Proveedor> ColProveedor
        {
            get { return colProveedor; }
            set { colProveedor = value; }
        }

        public List<Usuario> Colusuarios
        {
            get { return colusuarios; }
            set { colusuarios = value; }
        }
        public List<Gasto> ColGasto
        {
            get { return colGasto; }
            set { colGasto = value; }
        }


        //Crea un usuario y chequea si exite, Si no existe lo agrega a la coleccion de usuarios
        public int agregarUsuario(String nombre,String login, String passwd, rol tipo)
        {
            usuarioPersistente userPersistent = new usuarioPersistente();
            Usuario usuario = new Usuario(nombre, login, passwd, tipo);
            //if (!chequearUsuario(usuario,userPersistent))
            //{
                
                 return userPersistent.altaUsuario(nombre, login, passwd, (int) tipo);
                

           //}

           //// return false;
        }

        public Boolean editarUsuario(String nombre, String passwd, int id)
        {
            usuarioPersistente userPersistent = new usuarioPersistente();
            return userPersistent.modificarUsuario(nombre, passwd, id);

        }




        //Chequea si el login del usuario ya existe. Si exite devuelve true, sino false
        public DataSet chequearUsuario(String login, String pwd)
        {
            usuarioPersistente userPersistent = new usuarioPersistente();
            //foreach (Usuario tmpUsuario in Colusuarios)
            //{
            //    if (user.obtenerLogin()==tmpUsuario.obtenerLogin())
            //    {
            //        return true;
                    
            //    }
                
            //}
            //return false;
            DataSet ds = userPersistent.consultaUsuario(login, pwd);

            return ds;

        }

        public DataSet obtenerUsuarioXTipo(rol tipo)
        {
            Usuario usr = new Usuario();

            return usr.obtenerUsuariosXTipo(tipo);
        }


        //public void agregarCuentaProveedor(String numero, String descripcion, DateTime vencimiento, Proveedor prov, Usuario user)
        //{
        //   // Cuenta cuentaProveedor = new cuentaProveedor(numero, descripcion, vencimiento, prov);
        //   // user.agregarCuenta(cuentaProveedor);
            
        //}

        public Boolean agregarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario)
        {
            Cuenta cuenta = new Cuenta();
            return cuenta.ingresarCuenta(numero,descripcion, saldo, idProveedor, idUsuario);
            
        }


        public Proveedor obtenerProveedor(int id)
        {
            foreach (Proveedor prov in ColProveedor)
            {
                if (prov.CodProveedor==id)
                {
                    return prov;   
                }
            }
            return null;
        }


        //public Usuario obtenerUsuario(int id)
        //{
        //    foreach (Usuario user in Colusuarios)
        //    {
        //        if (user.Id==id)
        //        {
        //            return user;
        //        }
        //    }
        //    return null;
        //}


        public DataSet obtenerCuentasXusuario(int idUsuario)
        {

            Cuenta cuen = new Cuenta();
            return cuen.obtenerCuentasXusuario(idUsuario);



            //foreach (Usuario user in Colusuarios)
            //{
            //    if (user.Id==idUsuario)
            //    {
            //        return user.ColCuentas;
                    
            //    }
            //}
            //return null;
        
        }

        public Boolean ingresarGasto(String numero, String concepto, Decimal monto, String vencimiento, int estado, int idusuario)
        {
            Gasto gasto = new Gasto();

            return gasto.ingresarGasto(numero, concepto, monto, vencimiento, estado,idusuario);


        }

        public DataSet obtenerGastoXusuario(int idUsuario)
        {
            Gasto gasto = new Gasto();
           return gasto.obtenerGastosXusuario(idUsuario);
        }


        public Boolean realizarDeposito(int idCuenta,Decimal monto, String concepto)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.obtenerObjCuenta(idCuenta);
            Transaccion transacDep = new Transaccion(concepto,monto,idCuenta,tipoTransaccion.Deposito,estado.Realizada);
            if (cuenta.realizarMovimiento(transacDep))
            {
                transacDep.ingresarTransaccion(transacDep);
                return true;
            }
            return false;
        }

        public Boolean realizarExtraccion(int idCuenta, Decimal monto, String concepto)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.obtenerObjCuenta(idCuenta);
            Transaccion transacExt = new Transaccion(concepto, monto, idCuenta, tipoTransaccion.Extraccion, estado.Realizada);
            if (cuenta.realizarMovimiento(transacExt))
            {
                transacExt.ingresarTransaccion(transacExt);
                return true;
            }
            return false;
        }



        public Boolean realizarTransferencia(int pCuentaOrig, int pCuentaDestino, Decimal monto, String concepto)
        {
            Cuenta orig = new Cuenta();
            Cuenta dest = new Cuenta();
            orig = orig.obtenerObjCuenta(pCuentaOrig);
            dest = dest.obtenerObjCuenta(pCuentaDestino);
            Transaccion transac = new Transaccion(concepto, monto, pCuentaOrig,pCuentaDestino, tipoTransaccion.Transferencia, estado.Realizada);
            if (orig.realizarMovimiento(transac) && dest.realizarMovimiento(transac))
            {
                transac.ingresarTransaccion(transac);
                return true;    
            }
            return false;
            

        }


        public estadoCuenta verEstadoCuenta(DateTime fecha, Cuenta pCuenta)
        {
            return pCuenta.estadoCuentaProyectado(fecha);
        }

        public DataSet obtenerProveedores()
        {
            proveedorPersistente proveedorPersist = new proveedorPersistente();
            return proveedorPersist.obtenerProveedores();

        }

        public Boolean realizarPago(int idGasto, int idCuenta)
        {
            Gasto tmpGasto = new Gasto();
            Cuenta tmpCuenta = new Cuenta();

            try
            {

                //Armo los objetos de cuenta y gasto
                tmpGasto = tmpGasto.obtenerObjGasto(idGasto);
                tmpCuenta = tmpCuenta.obtenerObjCuenta(idCuenta);

                //Creo la transaccion
                Transaccion transac = new Transaccion("Pago cuenta", tmpGasto.Monto, DateTime.Today.ToString("dd/MM/yyyy"), tipoTransaccion.Extraccion, estado.Realizada, tmpGasto.Id, tmpCuenta.Id, 0);
                //Descuento los montos de la cuenta y cambio de estado al gasto
                tmpCuenta.realizarMovimiento(transac);
                tmpGasto.Estado = estado.Realizada;

                //guardo la cuenta y el gasto
                tmpCuenta.modificarCuenta(tmpCuenta);
                tmpGasto.modificarEstadoGasto(tmpGasto.Id, (int)tmpGasto.Estado);
                transac.ingresarTransaccion(transac);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

            

        }

        //public Boolean ingresarTransaccion(String pconcepto, Decimal monto, int ptipo, String fecha, int idgasto, int estado, int idcuenta, int idcuentadestino)
        //{
        //    Transaccion transac = new Transaccion();
        //    return transac.ingresarTransaccion(pconcepto, monto, ptipo, fecha, idgasto, estado, idcuenta, idcuentadestino);
        //}

        
        

    }

}