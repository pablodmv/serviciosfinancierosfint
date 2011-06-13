using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{    
    public class Deposito : Transaccion
    {
        private DateTime fechaDeposito;
        private String nombre;

        public Deposito(String pConcepto, Double pMonto, DateTime pFechaDeposito,tipoTransaccion pTipo, estadoTransaccion pEstado)
        {
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.fechaDeposito = pFechaDeposito;
            this.Tipo = pTipo;
            this.Estado = pEstado;

        }
        

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaDeposito
        {
            get { return fechaDeposito; }
            set { fechaDeposito = value; }
        }
        
    }
}