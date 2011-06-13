using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class Gasto : Transaccion
    {
        private DateTime fechaAPagar;
         private DateTime fechaRealizado;


        public Gasto(String pConcepto, Double pMonto, DateTime pFechaRealizado, DateTime pFechaPagar, tipoTransaccion pTipo, estadoTransaccion pEstado)
        {
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.FechaRealizado = pFechaRealizado;
            this.FechaAPagar = pFechaPagar;
            this.Tipo = pTipo;
            this.Estado = pEstado;

        }







        public DateTime FechaRealizado
        {
          get { return fechaRealizado; }
          set { fechaRealizado = value; }
        }

        public DateTime FechaAPagar
        {
          get { return fechaAPagar; }
          set { fechaAPagar = value; }
        }



        
    }
}