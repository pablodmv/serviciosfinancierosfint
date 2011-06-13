using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{    
    public abstract class Transaccion
    {
        private String concepto;
        private Double monto;
        private tipoCuenta tipo;
        private estadoTransaccion estado;

        protected estadoTransaccion Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        protected tipoCuenta Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
       

       
      

        protected Double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
     
        protected String Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
       
    }
}