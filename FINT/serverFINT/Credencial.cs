using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class Credencial
    {
       
        private String login;
        private String password;
        private rol rolUsuario;
        
        public Credencial(String pLogin, String pPassword, rol pRol)
        {
            
            this.Login = pLogin;
            this.Password = pPassword;
            this.TipoUsuario = pRol;
           
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
        
        
       
    }
}