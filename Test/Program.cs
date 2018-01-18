using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Pylonomial pylonomial = new Algebra.Pylonomial("-x^2^+8x-12");
            Algebra.Product product = new Algebra.Product();
            Boolean m=pylonomial.Factorization(out product);
            Console.WriteLine(product.ToString()+m);
            Console.ReadKey();
        }
    }
}
