using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{



    public class Sistema
    {
        public static Sistema instancia = null;
        private List<Usuario> colusuarios;
        private List<Cuenta> colCuentas;
        private List<Proveedor> colProveedor;


        private Sistema()
        {

        }


        public static Sistema getSistema()
        {

            if (intancia==nul)
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

        public List<Cuenta> ColCuentas
        {
            get { return colCuentas; }
            set { colCuentas = value; }
        }
        

        public List<Usuario> Colusuarios
        {
            get { return colusuarios; }
            set { colusuarios = value; }
        }
        
    }

}