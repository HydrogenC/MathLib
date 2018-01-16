using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    partial class Fraction
    {
        public Fraction Reciprocal()
        {
            return new Fraction(denominator, numerator);
        }

        public Fraction Sqrt()
        {
            Double a = Double.Parse(numerator.ToString());
            Double b = Double.Parse(denominator.ToString());
            a = Math.Floor(Math.Sqrt(a));
            b = Math.Floor(Math.Sqrt(b));
            return new Fraction(BigInteger.Parse(a.ToString()), BigInteger.Parse(b.ToString()));
        }

        public Fraction Pow(Decimal times)
        {
            Double a = Double.Parse(numerator.ToString());
            Double b = Double.Parse(denominator.ToString());
            a = Math.Floor(Math.Pow(a, (Double)times));
            b = Math.Floor(Math.Pow(b, (Double)times));
            return new Fraction(BigInteger.Parse(a.ToString()), BigInteger.Parse(b.ToString()));
        }

        private void Reduct()
        {
            BigInteger gcd = Arithmetic.IntegerFunctions.GetLCMGCD(numerator, denominator, Arithmetic.IntegerFunctions.GCD);
            numerator = numerator / gcd;
            denominator = denominator / gcd;
        }

        private void Adjust()
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        public Fraction Abs()
        {
            return new Fraction((BigInteger)Math.Abs((Decimal)numerator), denominator);
        }

        public static Fraction Parse(String fraction)
        {
            return new Fraction(fraction);
        }
    }
}
