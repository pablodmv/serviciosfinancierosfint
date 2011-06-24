using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using serverFINTPersitencia;

namespace serverFINT
{
    public class Cuenta 
    {
        private String numeroCuenta;
        private Double saldo;
        private String descripcion;
        private List<Transaccion> coltransacciones;
        private List<Gasto> colGasto;

      

        public Cuenta(String numero, Double saldo, String Descripcion)
        {
            this.NumeroCuenta = numero;
            this.Saldo = saldo;
            this.Descripcion = descripcion;

        }

        public Cuenta()
        {

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

        public List<Gasto> ColGasto
        {
            get { return colGasto; }
            set { colGasto = value; }
        }

        public Boolean ingresarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario) 
        {

            cuentaPersistente cuentaPersis = new cuentaPersistente();
           return cuentaPersis.ingresarCuenta(numero, descripcion, saldo, idProveedor, idUsuario);
        
        
        }














        #region Cuenta Members




        public String realizarMovimiento(Transaccion pTransaccion)
        {
            if (pTransaccion.Tipo == tipoTransaccion.Extraccion)
            {
                return ingresarGasto(pTransaccion);

            }
            else if (pTransaccion.Tipo == tipoTransaccion.Deposito)
            {
                return ingresarDeposito(pTransaccion);
            }
            return "Transaccion incorrecta";
        }

        private String ingresarDeposito(Transaccion pTransaccion)
        {
            this.Saldo += pTransaccion.Monto;
            return "Deposito Exitoso";
        }

        private String ingresarGasto(Transaccion pTransaccion)
        {
            this.Saldo -= pTransaccion.Monto;
            return "Gasto Ingresado";
        }


        public virtual estadoCuenta estadoCuentaProyectado(DateTime fecha)
        {
            //Creo la esturctura a devolver
            estadoCuenta retorno;
            retorno.movimientosPendiente = new ArrayList();
            retorno.saldo = this.Saldo;

            //recorro los gastos y busco las que estan pendientes hasta la fecha

            foreach (Gasto tmpGasto in this.ColGasto)
            {
                if (tmpGasto.Vencimiento.CompareTo(fecha) < 0 && tmpGasto.Estado == estado.Pendiente)
                {
                    retorno.saldo -= tmpGasto.Monto;
                    retorno.movimientosPendiente.Add(tmpGasto);
                }
            }

            //recorro las transacciones pendientes hasta la fecha

            foreach (Transaccion transac in coltransacciones)
            {
                if (transac.Fecha.CompareTo(fecha) < 0 && transac.EstadoTransaccion == estado.Pendiente)
                {
                    if (transac.Tipo == tipoTransaccion.Deposito)
                    {
                        retorno.saldo += transac.Monto;
                        retorno.movimientosPendiente.Add(transac);
                    }
                    else if (transac.Tipo == tipoTransaccion.Extraccion)
                    {
                        retorno.saldo -= transac.Monto;
                        retorno.movimientosPendiente.Add(transac);
                    }

                }

                
            }
            return retorno;
        }

        #endregion



        //#region Cuenta Members


        

        //public String realizarMovimiento(Transaccion pTransaccion)
        //{
        //    if (pTransaccion.Tipo==tipoTransaccion.Extraccion)
        //    {
        //        return ingresarGasto(pTransaccion);

        //    }
        //    else if (pTransaccion.Tipo==tipoTransaccion.Deposito)
        //    {
        //        return ingresarDeposito(pTransaccion);
        //    }
        //    return "Transaccion incorrecta";
        //}

        //private String ingresarDeposito(Transaccion pTransaccion)
        //{
        //        this.Saldo += pTransaccion.Monto;
        //        return "Deposito Exitoso";
        //}

        //private String ingresarGasto(Transaccion pTransaccion)
        //{
        //    this.Saldo -= pTransaccion.Monto;
        //    return "Gasto Ingresado";
        //}

        //public estadoCuenta estadoCuenta(DateTime fecha)
        //{
        //    //Creo la esturctura a devolver
        //    estadoCuenta retorno ;
        //    retorno.transacciones = new List<Transaccion>();
        //    retorno.saldo = this.Saldo;

        //    //recorro las transacciones y busco las que estan pendientes hasta la fecha

        //    foreach (Transaccion transac in coltransacciones)
        //    {
        //        if (transac.Fecha.CompareTo(fecha)<0 && transac.EstadoTransaccion==estado.Pendiente)
        //        {
        //            if (transac.Tipo==tipoTransaccion.Deposito)
        //            {
        //                retorno.saldo += transac.Monto;
        //                retorno.transacciones.Add(transac);
        //            }
        //            else if (transac.Tipo==tipoTransaccion.Extraccion)
        //            {
        //                retorno.saldo -= transac.Monto;
        //                retorno.transacciones.Add(transac);
        //            }
                    
        //        }
                
        //    }
        //    return retorno;

        //}

        //#endregion
    }

    public struct estadoCuenta
    {
        public ArrayList movimientosPendiente ;
        public Double saldo;
    }

}