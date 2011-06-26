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

        public estadoCuenta estadoCuenta(String numcue)
        {
            foreach (Cuenta cue in Colcuenta)
            {
                if (cue.NumCuenta.Equals("numcue"))
                {
                    return cue.getEstadoCuenta();
                    
                }
            }
            return null;
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
