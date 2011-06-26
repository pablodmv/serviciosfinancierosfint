using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;

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

      
        
      
        

        public Transaccion(String pConcepto, Decimal pMonto, String pFecha, tipoTransaccion pTipo, estado pEstado, int pidgastocancela, int idcuentainicia, int idcuentafinal)
        {
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.Tipo = pTipo;
            this.Fecha = pFecha;
            this.EstadoTransaccion = pEstado;
            this.IdGastoCancela = pidgastocancela;
            this.IdCuentainicial = idcuentainicia;
            this.idCuentaFinal = idcuentafinal;
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
            return transacpers.ingresarTransaccion(transac.Concepto, transac.Monto, (int)transac.Tipo, transac.Fecha, transac.IdGastoCancela, (int)transac.EstadoTransaccion, transac.IdCuentainicial, transac.IdCuentaFinal);
        }




    
    }
}