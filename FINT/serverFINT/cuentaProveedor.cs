using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class cuentaProveedor : Cuenta
    {
        private String numeroCuenta;
        private String descripcion;
        private DateTime vencimientoPago;
        private Proveedor proveedor;
        private List<Transaccion> coltransacciones;
 



        public cuentaProveedor(String numero, String descripcion, DateTime vencimiento, Proveedor prov)
        {
            this.NumeroCuenta = numero;
            this.Descripcion = descripcion;
            this.VencimientoPago = vencimiento;
            this.Proveedor = prov;

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