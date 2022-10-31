using System;
using System.Globalization;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var saldo = 15.75m;
            Console.WriteLine(saldo);
            //Console.WriteLine(saldo.ToString("c", CultureInfo.CreateSpecificCulture("pt-br")));
        }
    }

}
