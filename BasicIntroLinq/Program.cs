using System;
using System.Collections.Generic;
using BasicIntroLinq.RestrictionOperators;
using BasicIntroLinq.RestrictionOperators.Data;

namespace BasicIntroLinq
{
    class Program
    {
        private static Where _where = new Where();
        private static EFProducts _products = new EFProducts();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
         
            Console.WriteLine(_where.WhereSimple2(_products.Get));
        }
    }
}
