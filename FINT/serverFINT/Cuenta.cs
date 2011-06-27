using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using serverFINTPersitencia;
using System.Data;

namespace serverFINT
{
    public class Cuenta
    {
        private String numeroCuenta;
        private Decimal saldo;
        private String descripcion;
        private Proveedor proveedor;
        private int idUsuario;
        private int id;
        cuentaPersistente cuentaPersis;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }


        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public Cuenta(String numero, Decimal saldo, String Descripcion)
        {
            this.NumeroCuenta = numero;
            this.Saldo = saldo;
            this.Descripcion = descripcion;

        }

        public Cuenta()
        {
            cuentaPersis = new cuentaPersistente();
        }




        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public Decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public String NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }


        public Boolean ingresarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario)
        {
            return cuentaPersis.ingresarCuenta(numero, descripcion, saldo, idProveedor, idUsuario);
        }

        public DataSet obtenerCuentasXusuario(int idusuario)
        {
            return cuentaPersis.obtenerCuentaPorUsuario(idusuario);
        }


        public Cuenta obtenerObjCuenta(int idcuenta)
        {
            Proveedor prov = new Proveedor();
            Usuario user = new Usuario();
            DataSet dsCuenta = new DataSet();
            dsCuenta = cuentaPersis.obtenerObjCuenta(idcuenta);
            this.NumeroCuenta = dsCuenta.Tables[0].Rows[0]["NumeroCuenta"].ToString();
            this.Descripcion = dsCuenta.Tables[0].Rows[0]["Descripcion"].ToString();
            this.Saldo = Decimal.Parse(dsCuenta.Tables[0].Rows[0]["Saldo"].ToString());
            this.Proveedor = prov.obtenerObjProveedor(int.Parse(dsCuenta.Tables[0].Rows[0]["idProveedor"].ToString()));
            this.IdUsuario = int.Parse(dsCuenta.Tables[0].Rows[0]["idusuario"].ToString());
            this.Id = int.Parse(dsCuenta.Tables[0].Rows[0]["id"].ToString());
            return this;

        }

        public Boolean modificarCuenta(Cuenta tmpCuenta)
        {
            return cuentaPersis.modificarCuenta(tmpCuenta.NumeroCuenta, tmpCuenta.Descripcion, tmpCuenta.Saldo, tmpCuenta.Proveedor.Id, tmpCuenta.IdUsuario, tmpCuenta.Id);


        }

        public Boolean realizarMovimiento(Transaccion pTransaccion)
        {
            if (pTransaccion.Tipo == tipoTransaccion.Extraccion)
            {
                this.Saldo -= pTransaccion.Monto;
            }
            else if (pTransaccion.Tipo == tipoTransaccion.Deposito)
            {
                this.Saldo += pTransaccion.Monto;
            }
            else if (pTransaccion.Tipo == tipoTransaccion.Transferencia)
            {
                if (pTransaccion.IdCuentainicial == this.Id)
                {
                    this.Saldo -= pTransaccion.Monto;
                }
                else if (pTransaccion.IdCuentaFinal == this.Id)
                {
                    this.Saldo += pTransaccion.Monto;
                }

            }

            if (cuentaPersis.modificarCuenta(this.NumeroCuenta, this.Descripcion, this.Saldo, this.Proveedor.Id, this.IdUsuario, this.Id))
            {

                return true;
            }
            else
            {
                return false;
            }
        }


        private Boolean ingresarGasto(Transaccion pTransaccion)
        {
            this.Saldo -= pTransaccion.Monto;
            if (cuentaPersis.modificarCuenta(this.NumeroCuenta, this.Descripcion, this.Saldo, this.Proveedor.Id, this.IdUsuario, this.Id))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
        

}