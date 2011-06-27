using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appProveedor
{
    public class Controller
    {

        private static Controller instancia;
        private List<Cuenta> colcuenta;

        public List<Cuenta> Colcuenta
        {
            get { return colcuenta; }
            set { colcuenta = value; }
        }

        public static Controller getInstancia()
        {

            if (instancia == null)
            {
                instancia = new Controller();
            }
            return instancia;
        }



        public Controller()
        {
            colcuenta = new List<Cuenta>();
            Cuenta tmpcuenta = new Cuenta();
            tmpcuenta.cargarPagosGastos();
            colcuenta.Add(tmpcuenta);
        }

        public List<String> estadoCuenta(String numcuenta)
        {
            List<String> retorno = new List<string>();

            foreach (Cuenta cue in Colcuenta)
            {
                if (cue.NumCuenta.Equals(numcuenta))
                {
                    
                    Cuenta tmpcue = new Cuenta();
                    List<pago> tmpago = tmpcue.Colpago;
                    foreach (pago tmp in tmpago)
                    {
                        retorno.Add(tmp.ToString());

                    }
                    foreach (gasto gas in tmpcue.Colgasto)
                    {
                        retorno.Add(gas.ToString());

                    }

                    retorno.Add("Fecha de Cierre: " + tmpcue.FechaCierre);
                    retorno.Add("Credito disponible: " + tmpcue.Limite);
                }
                else
                {
                    retorno.Add("No existe la cuenta");
                }
                
            }
            
            return retorno;



        }
        public Boolean realizarPago(Decimal monto, String numcue) 
        {
           Cuenta tmpCuenta = new Cuenta();
            foreach (Cuenta cue in Colcuenta)
            {
                if (cue.NumCuenta.Equals("numcue"))
                {
                    tmpCuenta= cue;

                }
            }

            return tmpCuenta.realizarPago(monto);
            
        
        
        }



        





    }
}
