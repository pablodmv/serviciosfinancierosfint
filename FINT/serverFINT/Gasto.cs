using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;

namespace serverFINT
{
    public class Gasto
    {
       gastoPersistente gastoPersis;

        private int id;
        private int numeroFactura;
        private String concepto;
        private Double monto;
        private DateTime vencimiento;
        private estado estado;
        
        public Gasto()
        {
            gastoPersis = new gastoPersistente();
        }

        public Gasto(String pConcepto, Double pMonto, DateTime pVencimiento, estado pEstado, int pNumfact)
        {
            this.NumeroFactura = pNumfact;
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.Vencimiento = pVencimiento;
            this.Estado = pEstado;

        }
        public estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime Vencimiento
        {
            get { return vencimiento; }
            set { vencimiento = value; }
        }

        public Double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public String Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public int NumeroFactura
        {
            get { return numeroFactura; }
            set { numeroFactura = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Boolean ingresarGasto(String numero, String concepto, Decimal monto, String vencimiento, int estado, int idusuario)
        {
            return gastoPersis.ingresarGasto(numero, concepto, monto, vencimiento, estado,idusuario);
        
        
        }


    }
}
