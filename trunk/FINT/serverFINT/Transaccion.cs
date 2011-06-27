using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;
using System.Data;

namespace serverFINT
{
    public class Transaccion
    {
        private int numTransac;
        private String concepto;
        private Decimal monto;
        private tipoTransaccion tipo;
        private String fecha;
        private estado estadoTransaccion;
        private int idGastoCancela;
        private int idCuentainicial;
        private int idCuentaFinal;
        private transaccionPersistente transacpers;
        private String comprobante;

      


        public Transaccion()
        {
            transacpers = new transaccionPersistente();

        }
        public Transaccion(String concepto, Decimal monto, int idcuentainicial, tipoTransaccion tipo, estado est)
        {
            this.Concepto = concepto;
            this.Monto = monto;
            this.IdCuentainicial = idcuentainicial;
            this.Tipo = tipo;
            this.EstadoTransaccion = est;
            this.Fecha = DateTime.Today.ToString("dd/MM/yyyy");
            transacpers = new transaccionPersistente();

        }

        public Transaccion(String concepto, Decimal monto, int idcuentainicial,int idcuentafinal, tipoTransaccion tipo, estado est)
        {
            this.Concepto = concepto;
            this.Monto = monto;
            this.IdCuentainicial = idcuentainicial;
            this.IdCuentaFinal = idcuentafinal;
            this.Tipo = tipo;
            this.EstadoTransaccion = est;
            this.Fecha = DateTime.Today.ToString("dd/MM/yyyy");
            transacpers = new transaccionPersistente();

        }

        public String Comprobante
        {
            get { return comprobante; }
            set { comprobante = value; }
        }

        
      
        

        public Transaccion(String pConcepto, Decimal pMonto, String pFecha, tipoTransaccion pTipo, estado pEstado, int pidgastocancela, int idcuentainicia, int idcuentafinal, String comprobante)
        {
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.Tipo = pTipo;
            this.Fecha = pFecha;
            this.EstadoTransaccion = pEstado;
            this.IdGastoCancela = pidgastocancela;
            this.IdCuentainicial = idcuentainicia;
            this.idCuentaFinal = idcuentafinal;
            this.Comprobante = comprobante;
            transacpers = new transaccionPersistente();

        }

        public String Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public Decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public tipoTransaccion Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


      
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

      
        public int NumTransac
        {
            get { return numTransac; }
            set { numTransac = value; }
        }
        public estado EstadoTransaccion
        {
            get { return estadoTransaccion; }
            set { estadoTransaccion = value; }
        }

        public int IdGastoCancela
        {
            get { return idGastoCancela; }
            set { idGastoCancela = value; }
        }
        public int IdCuentainicial
        {
            get { return idCuentainicial; }
            set { idCuentainicial = value; }
        }
        public int IdCuentaFinal
        {
            get { return idCuentaFinal; }
            set { idCuentaFinal = value; }
        }

        public Boolean ingresarTransaccion(Transaccion transac)
        {
            return transacpers.ingresarTransaccion(transac.Concepto, transac.Monto, (int)transac.Tipo, transac.Fecha, transac.IdGastoCancela, (int)transac.EstadoTransaccion, transac.IdCuentainicial, transac.IdCuentaFinal,transac.Comprobante);
        }

        public Boolean modificarTransaccion(Transaccion transac)
        {
            return transacpers.modificarTransaccion(transac.NumTransac,transac.Concepto, transac.Monto, (int)transac.Tipo, transac.Fecha, transac.IdGastoCancela, (int)transac.EstadoTransaccion, transac.IdCuentainicial, transac.IdCuentaFinal,transac.Comprobante);
        }


        public Transaccion obtenerObjTransac(int idtransac)
        {
            transaccionPersistente persistranc = new transaccionPersistente();
            Transaccion transac = new Transaccion();
            DataSet dsTransaccion = new DataSet();
            dsTransaccion = persistranc.obtenerTransaccionXid(idtransac);
            this.NumTransac = int.Parse(dsTransaccion.Tables[0].Rows[0]["NumTransac"].ToString());
            this.Concepto = dsTransaccion.Tables[0].Rows[0]["Concepto"].ToString();
            this.Monto = Decimal.Parse(dsTransaccion.Tables[0].Rows[0]["Monto"].ToString());
            this.Fecha = dsTransaccion.Tables[0].Rows[0]["Fecha"].ToString();
            this.IdGastoCancela = int.Parse(dsTransaccion.Tables[0].Rows[0]["idGasto"].ToString());
            this.IdCuentainicial = int.Parse(dsTransaccion.Tables[0].Rows[0]["idCuenta"].ToString());
            this.IdCuentaFinal = int.Parse(dsTransaccion.Tables[0].Rows[0]["idCuentaDestino"].ToString());
            this.Comprobante = dsTransaccion.Tables[0].Rows[0]["Comprobante"].ToString();

            if (int.Parse(dsTransaccion.Tables[0].Rows[0]["Estado"].ToString())==(int)estado.Pendiente)
            {
                this.EstadoTransaccion=estado.Pendiente;

            }
            else if (int.Parse(dsTransaccion.Tables[0].Rows[0]["Estado"].ToString()) == (int)estado.Realizada)
            {
                this.EstadoTransaccion = estado.Realizada;
            }

            if (int.Parse(dsTransaccion.Tables[0].Rows[0]["Tipo"].ToString())==(int)tipoTransaccion.Deposito)
            {
                this.Tipo = tipoTransaccion.Deposito;
            }
            else if (int.Parse(dsTransaccion.Tables[0].Rows[0]["Tipo"].ToString())==(int)tipoTransaccion.Extraccion)
            {
                this.Tipo = tipoTransaccion.Extraccion;
            }
            else if (int.Parse(dsTransaccion.Tables[0].Rows[0]["Tipo"].ToString()) == (int)tipoTransaccion.Transferencia)
            {
                this.Tipo = tipoTransaccion.Transferencia;
            }

            return this;
        }


        public DataSet obtenerTransacciones()
        {

            transaccionPersistente persistranc = new transaccionPersistente();
            return persistranc.obtenerTransaccionPendiente();
        
        }
    }
}