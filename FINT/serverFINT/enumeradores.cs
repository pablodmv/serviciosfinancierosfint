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
   
    public enum rol
    {
        Administrador,
        Usuario,
        Cliente
    }

    public enum estado
    {
        Pendiente,
        Realizada
    }


    public enum tipoTransaccion
    {
        Extraccion,
        Deposito,
        Transferencia
    }
}
