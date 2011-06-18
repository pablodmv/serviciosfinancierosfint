using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{
    public class cuentaPersonal : Cuenta
    {
        private String numeroCuenta;

      
        private Double saldo;
        private String descripcion;
        private List<Transaccion> coltransacciones;

        public cuentaPersonal(String numero, Double saldo, String Descripcion)
        {
            this.NumeroCuenta = numero;
            this.Saldo = saldo;
            this.Descripcion = descripcion;

        }



        public List<Transaccion> Coltransacciones
        {
            get { return coltransacciones; }
            set { coltransacciones = value; }
        }
        

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
      

        public Double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public String NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }




        #region Cuenta Members

        public void realizarMovimiento(Transaccion pTransaccion)
        {
            throw new NotImplementedException();
        }

        public void estadoCuenta(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}