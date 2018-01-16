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
        public static explicit operator Decimal(Fraction a)
        {
            return (Decimal)a.Numerator / (Decimal)a.Denominator;
        }
        public static explicit operator Double(Fraction a)
        {
            return (Double)(Decimal)a;
        }
        public static explicit operator Int64(Fraction a)
        {
            return (Int64)Math.Floor((Decimal)a);
        }
        public static explicit operator String(Fraction a)
        {
            return a.ToString();
        }
        public static explicit operator Fraction(Decimal a)
        {
            Decimal multiplier = 1;
            while (true)
            {
                if (a * multiplier % 1 == 0)
                {

                }
            }
        }
    }
}
