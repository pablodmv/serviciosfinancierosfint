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
        private DateTime fecha;
        private estado estadoTransaccion;
        private List<Gasto> colGastoCancela;

       

      
        
      
        

        public Transaccion(String pConcepto, Double pMonto, DateTime pFecha, tipoTransaccion pTipo, estado pEstado)
        {
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.Tipo = pTipo;
            this.Fecha = pFecha;
            this.EstadoTransaccion = pEstado;

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


      
        public DateTime Fecha
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

        public List<Gasto> ColGastoCancela
        {
            get { return colGastoCancela; }
            set { colGastoCancela = value; }
        }
    }
}