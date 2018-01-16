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
            Decimal a = (Decimal)numerator;
            Decimal b = (Decimal)denominator;
            a = Decimal.Floor((Decimal)Math.Sqrt((Double)a));
            b = Decimal.Floor((Decimal)Math.Sqrt((Double)b));
            return new Fraction((BigInteger)a, (BigInteger)b);
        }

        public Fraction Pow(Decimal times)
        {
            Decimal a = (Decimal)numerator;
            Decimal b = (Decimal)denominator;
            a = (Decimal)Math.Floor(Math.Pow((Double)a,(Double)times));
            b = (Decimal)Math.Floor(Math.Pow((Double)b,(Double)times));
            return new Fraction((BigInteger)a, (BigInteger)b);
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
