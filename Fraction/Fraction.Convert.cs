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
        public static implicit operator Decimal(Fraction a)
        {
            return (Decimal)a.Numerator / (Decimal)a.Denominator;
        }
        public static explicit operator BigInteger(Fraction a)
        {
            return (BigInteger)Math.Floor(a);
        }
        public static explicit operator String(Fraction a)
        {
            return a.ToString();
        }
        public static implicit operator Fraction(Decimal a)
        {
            return new Fraction(a);
        }
        public static explicit operator Fraction(String a)
        {
            return new Fraction(a);
        }
        public static explicit operator Fraction(BigInteger a)
        {
            return new Fraction(a);
        }
    }
}
