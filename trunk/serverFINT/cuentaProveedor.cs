using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class cuentaProveedor : Cuenta
    {
        private String descripcion;
        private DateTime vencimientoPago;
        private Proveedor proveedor;
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
       

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        

        public DateTime VencimientoPago
        {
            get { return vencimientoPago; }
            set { vencimientoPago = value; }
        }
     

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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