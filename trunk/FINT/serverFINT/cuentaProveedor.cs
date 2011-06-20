using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class cuentaProveedor : Cuenta
    {
        
        private Proveedor proveedor;
        

        public cuentaProveedor(String numero, String descripcion, DateTime vencimiento, Proveedor prov)
        {
            this.NumeroCuenta = numero;
            this.Descripcion = descripcion;
            //this.VencimientoPago = vencimiento;
            this.Proveedor = prov;
            

        }




        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        

       

        #region Cuenta Members

        //public override String realizarMovimiento(Transaccion pTransaccion)
        //{
        //    this.Coltransacciones.Add(pTransaccion);
        //    if (pTransaccion.Tipo=tipoTransaccion.Deposito)
        //    {
        //        return realizarDeposito(pTransaccion);
        //    }
        //    else if (pTransaccion.Tipo==tipoTransaccion.Extraccion)
        //    {
        //        return realizarExtraccion(pTransaccion);
        //    }
            

        //}

        //private string realizarExtraccion(Transaccion pTransaccion)
        //{
        //    if (pTransaccion.EstadoTransaccion=estado.Realizada)
        //    {
        //        this.Saldo += pTransaccion.Monto;    
        //    }
            
        //    return "Extraccion exitosa";
        //}

        //private void realizarDeposito(Transaccion pTransaccion)
        //{
        //    if (pTransaccion.EstadoTransaccion==estado.Realizada)
        //    {
        //        this.Saldo -= pTransaccion.Monto;    
        //    }
        //    //return "Pago Exitoso";
        //}

        public override estadoCuenta estadoCuenta(DateTime fecha)
        {
            estadoCuenta retorno;
            retorno.saldo = this.Saldo;
            retorno.transacciones = this.Coltransacciones;
            return retorno;
        }

        #endregion

    }

}