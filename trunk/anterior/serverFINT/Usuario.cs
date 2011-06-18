using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class Usuario
    {
        private String nombre;
        private List<Cuenta> colCuentas;

        public Usuario(String pNombre)
        {
            this.Nombre = pNombre;

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
        
    }

}