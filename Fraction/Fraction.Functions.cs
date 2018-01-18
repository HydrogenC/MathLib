using System;

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

            return new Fraction((Int64)Math.Sqrt(denominator), (Int64)Math.Sqrt(denominator));
        }

        public Fraction HDSqrt()
        {
            return new Fraction(Math.Sqrt(denominator), Math.Sqrt(denominator));
        }

        public Fraction Pow(Decimal times)
        {
            Decimal a = numerator;
            Decimal b = denominator;
            a = (Decimal)Math.Floor(Math.Pow((Double)a, (Double)times));
            b = (Decimal)Math.Floor(Math.Pow((Double)b, (Double)times));
            return new Fraction((Int64)a, (Int64)b);
        }

        private void Reduct()
        {
            if (numerator != 0)
            {
                Int64 gcd = Arithmetic.IntegerFunctions.GetLCMGCD(numerator, denominator, Arithmetic.IntegerFunctions.GCD);
                numerator = numerator / gcd;
                denominator = denominator / gcd;
            }
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
            return new Fraction(Math.Abs(numerator), denominator);
        }

        public static Fraction Parse(String fraction)
        {
            return new Fraction(fraction);
        }
    }
}
