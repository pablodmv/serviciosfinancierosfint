using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{
    public class Transaccion
    {
        private int numTransac;
        private String concepto;
        private Double monto;
        private tipoTransaccion tipo;
        private estadoTransaccion estado;
        private DateTime fechaRealizado;
        private DateTime fechaEstimada;

        public Transaccion(String pConcepto, Double pMonto, DateTime pFechaDeposito, tipoTransaccion pTipo, estadoTransaccion pEstado)
        {
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.Tipo = pTipo;
            this.Estado = pEstado;

        }

        public String Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public Double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public tipoTransaccion Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public estadoTransaccion Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaRealizado
        {
            get { return fechaRealizado; }
            set { fechaRealizado = value; }
        }

        public DateTime FechaEstimada
        {
            get { return fechaEstimada; }
            set { fechaEstimada = value; }
        }

        public int NumTransac
        {
            get { return numTransac; }
            set { numTransac = value; }
        }
    }
}