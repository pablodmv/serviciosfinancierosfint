using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class Credenciales
    {
        private Usuario usuario;
        private String login;
        private String password;
        private rol tipoUsuario;
        
        public Credenciales(Usuario pUsuario, String pLogin, String pPassword, rol pRol)
        {
            this.Usuario = pUsuario;
            this.Login = pLogin;
            this.Password = pPassword;
            this.TipoUsuario = pRol;
           
        }

        public rol TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
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
        
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
       
    }
}