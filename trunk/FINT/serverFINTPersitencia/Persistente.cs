using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINTPersitencia
{
    public class Persistente
    {
        protected String usuario;// = Environment.MachineName;
        protected String conn;// = "integrated security=SSPI;data source=PABLO-PC\\SQLEXPRESS;initial catalog=FINT"; 

        public Persistente()
        {
            usuario = Environment.MachineName;
            conn = "integrated security=SSPI;data source=" + usuario.ToUpper() + "\\SQLEXPRESS;initial catalog=FINT";
        }

    }
}
