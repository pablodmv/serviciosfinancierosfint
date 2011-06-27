using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;
using System.Data;

namespace serverFINT
{
    public class Gasto
    {
       gastoPersistente gastoPersis;

        private int id;
        private String numeroFactura;
        private String concepto;
        private Decimal monto;
        private String vencimiento;
        private estado estado;
        private int idUsuario;

     
        
        public Gasto()
        {
            gastoPersis = new gastoPersistente();
        }

        public Gasto(String pnum,String pConcepto, Decimal pMonto, String pVencimiento, estado pEstado, int pidUsuario)
        {
            this.NumeroFactura = pnum;
            this.Concepto = pConcepto;
            this.Monto = pMonto;
            this.Vencimiento = pVencimiento;
            this.Estado = pEstado;
            this.IdUsuario = pidUsuario;

        }
        public estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Vencimiento
        {
            get { return vencimiento; }
            set { vencimiento = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public Decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public String Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public String NumeroFactura
        {
            get { return numeroFactura; }
            set { numeroFactura = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Boolean ingresarGasto(String numero, String concepto, Decimal monto, String vencimiento, int estado, int idusuario, int idcuenta)
        {
            return gastoPersis.ingresarGasto(numero, concepto, monto, vencimiento, estado,idusuario, idcuenta);
        }

        public DataSet obtenerGastosXusuario(int idusuario)
        {
            return gastoPersis.obtenerGastosPorUsuario(idusuario);
        }

        public Boolean modificarGasto(int id, String numero, String concepto, Decimal monto, String vencimiento, int estado)
        {
            return gastoPersis.modificarGasto(id, numero, concepto, monto, vencimiento, estado);
        }

        public Boolean modificarEstadoGasto(int idgasto, int estado)
        {
            return gastoPersis.modificarEstadoGasto(idgasto, estado);
        
        }

        public DataSet obtenerGastoXcuenta(int idcuenta)
        {
            return gastoPersis.obtenerGastosPendientePorCuenta(idcuenta);

        }
        public Gasto obtenerObjGasto(int idGasto)
        {
            DataSet dsGasto = new DataSet();
            dsGasto = gastoPersis.obtenerGastosPorId(idGasto);
            this.NumeroFactura = dsGasto.Tables[0].Rows[0]["NumFactura"].ToString();
            this.Concepto = dsGasto.Tables[0].Rows[0]["Concepto"].ToString();
            this.Monto = Decimal.Parse(dsGasto.Tables[0].Rows[0]["Monto"].ToString());
            this.Vencimiento = dsGasto.Tables[0].Rows[0]["Vencimiento"].ToString();
            
            this.IdUsuario = int.Parse(dsGasto.Tables[0].Rows[0]["idUsuario"].ToString());
            this.Id = int.Parse(dsGasto.Tables[0].Rows[0]["id"].ToString());
            if (int.Parse(dsGasto.Tables[0].Rows[0]["Estado"].ToString())==0)
            {
                this.Estado = estado.Pendiente;

            }
            else if (int.Parse(dsGasto.Tables[0].Rows[0]["Estado"].ToString())==1)
            {
                this.Estado = estado.Realizada;
            }
            return this;
            
        }



    }
}
