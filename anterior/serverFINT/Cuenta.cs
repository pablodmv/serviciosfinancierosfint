using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public interface Cuenta
    {
       
        public void realizarMovimiento();
        public Transaccion listarTransaccion();
        
    }
}