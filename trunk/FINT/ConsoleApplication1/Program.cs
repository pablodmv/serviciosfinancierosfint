using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINT;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema pepe = Sistema.getInstancia();
            Boolean hola = pepe.ingresarGasto("hasdas", "hsjhdkjas", 222, "25/06/2001", 0);
            Console.WriteLine(hola);
        }
    }
}
