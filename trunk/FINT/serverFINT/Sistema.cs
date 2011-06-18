using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{



    public class Sistema
    {
        private static Sistema instancia = null;
        private List<Usuario> colusuarios;
        private List<Proveedor> colProveedor;


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

        //Crea un usuario y chequea siexite, Si no existe lo agrega a la coleccion de usuarios
        public Boolean agregarUsuario(String nombre,String login, String passwd, rol tipo)
        {
            Credencial cred=new Credencial(login,passwd,tipo);
            Usuario usuario = new Usuario(nombre, cred);
            if (!chequearUsuario(usuario))
            {
                colusuarios.Add(usuario);
                return true;
            }

            return false;
        }

        //Chequea si el login del usuario ya existe. Si exite devuelve true, sino false
        public Boolean chequearUsuario(Usuario user)
        {
            foreach (Usuario tmpUsuario in Colusuarios)
            {
                if (user.obtenerLogin()==tmpUsuario.obtenerLogin())
                {
                    return true;
                    
                }
                
            }
            return false;
        }
        
        public void agregarCuentaProveedor(DateTime vencimiento, String desc, Proveedor prov, String numero, Usuario user)
        {
            Cuenta cuentaProveedor = new cuentaProveedor(numero, desc, vencimiento, prov);
            user.agregarCuenta(cuentaProveedor);
            
        }

        public void agregarCuentaPersonal(String numero, Double saldo, String desc, Usuario user)
        {
            Cuenta cuentapers = new cuentaPersonal(numero, saldo, desc);
            user.agregarCuenta(cuentapers);
            
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


        public Usuario obtenerUsuario(int id)
        {
            foreach (Usuario user in Colusuarios)
            {
                if (user.Id==id)
                {
                    return user;
                }
            }
            return null;
        }


        public List<Cuenta> obtenerCuentasXusuario(int idUsuario)
        {
            foreach (Usuario user in Colusuarios)
            {
                if (user.Id==idUsuario)
                {
                    return user.ColCuentas;
                    
                }
            }
            return null;
        
        }



        public Boolean realizarMovimiento(Cuenta pCuenta, Transaccion pTransaccion)
        {
        
                
        }

        public Boolean realizarTransferencia(Cuenta pCuentaOrig, Cuenta pCuentaDestino, Transaccion pTransaccion)
        {

            
        }
    }

}