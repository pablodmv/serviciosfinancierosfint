using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class Usuario
    {
        private Credencial credencial;
        private int id;

       
      
        private String nombre;
        private List<Cuenta> colCuentas;

        public Usuario(String pNombre, Credencial cred)
        {
            this.Nombre = pNombre;
            this.Credencial = cred;

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

        public void agregarCuenta(Cuenta cuenta)
        {
            this.colCuentas.Add(cuenta);
        }

        public String obtenerLogin()
        {
            return this.Credencial.Login;
        
        }
    }

}