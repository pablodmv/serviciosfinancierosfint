using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINT;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema pepe = Sistema.getInstancia();
            Boolean hola = pepe.confirmarPagoCliente(74);
            Console.WriteLine(hola);
        }
    }
}
