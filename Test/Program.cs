using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Product product = new Algebra.Product("-34a(3s+4d)(7u-3s)");
            Console.WriteLine(product.ToString());
            Console.ReadKey();
        }
    }
}
