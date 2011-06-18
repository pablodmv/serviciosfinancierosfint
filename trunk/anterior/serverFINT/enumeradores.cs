using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{
    public enum tipoProveedor
    {
        Financiera,
        Personal,
        Servicios
    }
    public enum tipoCuenta
    {
        tarjetaCredito,
        bancaria,
        personal,
        generica
    }
    public enum rol
    {
        Administrador,
        Usuario
    }

    public enum estadoTransaccion
    {
        Pendiente,
        Pagado,
        Depositado
    }

    public enum tipoTransaccion
    {
        Gasto,
        Deposito
    }
}
