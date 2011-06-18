using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public interface Cuenta
    {
       
        void realizarMovimiento(Transaccion pTransaccion);
        void estadoCuenta(DateTime fecha);
        
    }
}