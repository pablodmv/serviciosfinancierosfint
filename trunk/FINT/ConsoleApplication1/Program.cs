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
            Boolean hola = pepe.realizarTransferencia(1, 11, 200, "Pruebadebug");
            Console.WriteLine(hola);
        }
    }
}
