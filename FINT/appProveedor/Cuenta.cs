using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appProveedor
{
    public class Cuenta
    {
        private String numCuenta="1234";
        private Decimal saldo=(Decimal)4000.00;
        private Decimal limite = (Decimal)12000.00;
        private String descripcion="Tarjeta Visa";
        private List<pago> colpago = new List<pago>();


        private List<gasto> colgasto = new List<gasto>();

      


        public Cuenta()
        {
            this.cargarPagosGastos();
        }
        public List<pago> Colpago
        {
            get { return colpago; }
            set { colpago = value; }
        }
        public String NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }
        public List<gasto> Colgasto
        {
            get { return colgasto; }
            set { colgasto = value; }
        }
        public Decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
     
        public Decimal Limite
        {
            get { return limite; }
            set { limite = value; }
        }

        public void cargarPagosGastos()
        {
            pago pago1 = new pago("2354568A", (Decimal)4500.00, "01/02/2011");
            pago pago2 = new pago("2354448A", (Decimal)2200.00, "01/03/2011");
            pago pago3 = new pago("23222568A", (Decimal)1200.00, "01/04/2011");
            pago pago4 = new pago("23546666A", (Decimal)6800.00, "01/05/2011");
            pago pago5 = new pago("2888568A", (Decimal)3255.00, "01/06/2011");
            gasto gast1 = new gasto("999", "TIENDA INGLESA", "13/06/2011", (Decimal)4.500, 1);
            gasto gast2 = new gasto("123", "VIDOL CALZADOS", "13/06/2011", (Decimal)1.500, 1);
            gasto gast3 = new gasto("456", "LOS 4 ASES", "13/06/2011", (Decimal)2.500, 1);
            Colgasto.Add(gast1);
            Colgasto.Add(gast2);
            Colgasto.Add(gast3);
            Colpago.Add(pago1);
            Colpago.Add(pago2);
            Colpago.Add(pago3);
            Colpago.Add(pago4);
            Colpago.Add(pago5);
        }

        public estadoCuenta getEstadoCuenta()
        {
            estadoCuenta estado = new estadoCuenta();

            foreach (gasto gas in Colgasto)
            {
                estado.Colgasto.Add(gas);
                estado.Total = gas.Monto;
                
            }

            return estado;
        }

        public Boolean realizarPago(Decimal monto)
        {

            pago pag = new pago();
            pag.Monto = monto;
            pag.Fecha = DateTime.Today.ToString("dd/MM/yyyy");
            this.saldo -= monto;
            Colpago.Add(pag);
            return true;
        }


    }

    public class pago
    {
        private String numeroFactura;
        private Decimal monto;
        private String fecha;

        public pago()
        {

        }
        public pago(String numfac,Decimal monto,String fecha)
        {
            this.NumeroFactura = numfac;
            this.Monto = monto;
            this.Fecha=fecha;
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }



        public Decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }
       

        public String NumeroFactura
        {
            get { return numeroFactura; }
            set { numeroFactura = value; }
        }
       
    }

    public class gasto
    {

        String numFact;
        String concepto;
        String fechaCompra;
        Decimal monto;
        int estado; // 1 -pagado, 0-pendiente

        public gasto()
        {

        }

        public gasto(String num, String concepto, String fechaCompra, Decimal monto, int est)
        {
            this.NumFact= num;
            this.Concepto=concepto;
            this.FechaCompra=fechaCompra;
            this.Monto=monto;
            this.Estado = est;
        }

        public Decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public String FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }

        public String Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public String NumFact
        {
            get { return numFact; }
            set { numFact = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    
    }

    public class estadoCuenta
    {

        private Decimal total;
        private List<gasto> colgasto;

        public Decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        

        public List<gasto> Colgasto
        {
            get { return colgasto; }
            set { colgasto = value; }
        }
    
    
    }

}
