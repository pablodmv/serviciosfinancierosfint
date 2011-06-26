using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using serverFINTPersitencia;

namespace serverFINT
{

    public class Usuario
    {
        private Credencial credencial;
        private int id;     
        private String nombre;
        private List<Cuenta> colCuentas;
        private List<Gasto> colGasto;
        private String login;
        private String password;
        private rol rolUsuario;
        private usuarioPersistente usuarioPersis = new usuarioPersistente();


        public Usuario()
        {
        }

        public Usuario(String pNombre, String pLogin, String pPassword, rol pRol)
        {
            this.Nombre = pNombre;
            this.Login = pLogin;
            this.Password = pPassword;
            this.TipoUsuario = pRol;

        }



        public List<Cuenta> ColCuentas
        {
            get { return colCuentas; }
            set { colCuentas = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Credencial Credencial
        {
            get { return credencial; }
            set { credencial = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public rol TipoUsuario
        {
            get { return rolUsuario; }
            set { rolUsuario = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        private List<Gasto> ColGasto
        {
            get { return colGasto; }
            set { colGasto = value; }
        }

      
       



        public void agregarGasto(Gasto gasto)
        {
            this.ColGasto.Add(gasto);
        }

        public String obtenerLogin()
        {
            return this.Credencial.Login;
        
        }

        public DataSet obtenerUsuariosXTipo(rol tipo)
        {
            return this.usuarioPersis.obtenerUsuarios((int)tipo);

        }


    }

}