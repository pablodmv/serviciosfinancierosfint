using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{
    public class cuentaPersonal : Cuenta
    {
        private Double saldo;
        private String descripcion;
        private List<Transaccion> coltransacciones;
        private tipoCuenta tipoCuenta;

        public tipoCuenta TipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
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



        #region Cuenta Members

        public void realizarMovimiento()
        {
            throw new NotImplementedException();
        }

        public Transaccion listarTransaccion()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}