using System;
using static Arithmetic.IntegerFunctions;

namespace Fraction
{
    partial class Fraction
    {
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Int64 lcm = GetLCMGCD(a.Denominator, b.Denominator, LCM);
            return new Fraction(a.Numerator * (lcm / a.Denominator) + b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Int64 lcm = GetLCMGCD(a.Denominator, b.Denominator, LCM);
            return new Fraction(a.Numerator * (lcm / a.Denominator) - b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator /(Fraction a, Fraction b) => a * b.Reciprocal();

        public static Boolean operator ==(Fraction a, Fraction b) => a.ToString() == b.ToString();

        public static Boolean operator !=(Fraction a, Fraction b) => a.ToString() != b.ToString();

        public static Boolean operator <(Fraction a, Fraction b) => (Decimal)a < (Decimal)b;

        public static Boolean operator >(Fraction a, Fraction b) => (Decimal)a > (Decimal)b;

        public static Boolean operator <=(Fraction a, Fraction b) => (Decimal)a <= (Decimal)b;

        public static Boolean operator >=(Fraction a, Fraction b) => (Decimal)a >= (Decimal)b;

        public static Fraction operator +(Int64 a, Fraction b) => (Fraction)a + b;

        public static Fraction operator +(Fraction a, Int64 b) => b + a;

        public static Fraction operator +(Fraction a, Decimal b) => a + (Fraction)b;

        public static Fraction operator +(Decimal a, Fraction b) => b + a;

        public static Fraction operator -(Int64 a, Fraction b) => (Fraction)a - b;

        public static Fraction operator -(Fraction a, Int64 b) => a - (Fraction)b;

        public static Fraction operator -(Fraction a, Decimal b) => a - (Fraction)b;

        public static Fraction operator -(Decimal a, Fraction b) => (Fraction)a - b;

        public static Fraction operator *(Int64 a, Fraction b) => (Fraction)a * b;

        public static Fraction operator *(Fraction a, Int64 b) => b * a;

        public static Fraction operator *(Fraction a, Decimal b) => a * (Fraction)b;

        public static Fraction operator *(Decimal a, Fraction b) => b * a;

        public static Fraction operator /(Int64 a, Fraction b) => (Fraction)a / b;

        public static Fraction operator /(Fraction a, Int64 b) => a / (Fraction)b;

        public static Fraction operator /(Fraction a, Decimal b) => a / (Fraction)b;

        public static Fraction operator /(Decimal a, Fraction b) => (Fraction)a / b;

        public static Fraction operator -(Fraction a) => new Fraction(-a.Numerator, a.Denominator);

        public static Fraction operator +(Fraction a) => a;

        public static Int64 operator %(Fraction a, Fraction b) => (Int64)((Decimal)a % (Decimal)b);

        public static Int64 operator %(Decimal a, Fraction b) => (Int64)(a % (Decimal)b);

        public static Int64 operator %(Fraction a, Decimal b) => (Int64)((Decimal)a % b);

        public static Int64 operator %(Int64 a, Fraction b) => (Int64)(a % (Decimal)b);

        public static Int64 operator %(Fraction a, Int64 b) => (Int64)((Decimal)a % b);

        public static Boolean operator >(Int64 a, Fraction b) => a > (Decimal)b;

        public static Boolean operator <(Int64 a, Fraction b) => a < (Decimal)b;

        public static Boolean operator >=(Int64 a, Fraction b) => a >= (Decimal)b;

        public static Boolean operator <=(Int64 a, Fraction b) => a <= (Decimal)b;

        public static Boolean operator >(Decimal a, Fraction b) => a > (Decimal)b;

        public static Boolean operator <(Decimal a, Fraction b) => a < (Decimal)b;

        public static Boolean operator >=(Decimal a, Fraction b) => a >= (Decimal)b;

        public static Boolean operator <=(Decimal a, Fraction b) => a <= (Decimal)b;

        public static Boolean operator >(Fraction a, Int64 b) => (Decimal)a > b;

        public static Boolean operator <(Fraction a, Int64 b) => (Decimal)a < b;

        public static Boolean operator >=(Fraction a, Int64 b) => (Decimal)a >= b;

        public static Boolean operator <=(Fraction a, Int64 b) => (Decimal)a <= b;

        public static Boolean operator >(Fraction a, Decimal b) => (Decimal)a > b;

        public static Boolean operator <(Fraction a, Decimal b) => (Decimal)a < b;

        public static Boolean operator >=(Fraction a, Decimal b) => (Decimal)a >= b;

        public static Boolean operator <=(Fraction a, Decimal b) => (Decimal)a <= b;

        public static Boolean operator ==(Fraction a, Int64 b) => a == (Fraction)b;

        public static Boolean operator !=(Fraction a, Int64 b) => a != (Fraction)b;

        public static Boolean operator ==(Int64 a, Fraction b) => b == a;

        public static Boolean operator !=(Int64 a, Fraction b) => b != a;

        public static Boolean operator ==(Fraction a, Decimal b) => a == (Fraction)b;

        public static Boolean operator !=(Fraction a, Decimal b) => a != (Fraction)b;

        public static Boolean operator ==(Decimal a, Fraction b) => b == a;

        public static Boolean operator !=(Decimal a, Fraction b) => b != a;

        public static Fraction operator +(Double a, Fraction b) => (Fraction)a + b;

        public static Fraction operator +(Fraction a, Double b) => b + a;

        public static Fraction operator -(Double a, Fraction b) => (Fraction)a - b;

        public static Fraction operator -(Fraction a, Double b) => a - (Fraction)b;

        public static Fraction operator *(Fraction a, Double b) => a * (Fraction)b;

        public static Fraction operator *(Double a, Fraction b) => b * a;

        public static Fraction operator /(Double a, Fraction b) => (Fraction)a / b;

        public static Fraction operator /(Fraction a, Double b) => a / (Fraction)b;

        public static Boolean operator ==(Fraction a, Double b) => a == (Fraction)b;

        public static Boolean operator !=(Fraction a, Double b) => a != (Fraction)b;

        public static Boolean operator ==(Double a, Fraction b) => (Fraction)a == b;

        public static Boolean operator !=(Double a, Fraction b) => (Fraction)a != b;

        public static Boolean operator >(Fraction a, Double b) => (Double)a > b;

        public static Boolean operator <(Fraction a, Double b) => (Double)a < b;

        public static Boolean operator >(Double a, Fraction b) => a > (Double)b;

        public static Boolean operator <(Double a, Fraction b) => a < (Double)b;

        public static Boolean operator >=(Fraction a, Double b) => (Double)a >= b;

        public static Boolean operator <=(Fraction a, Double b) => (Double)a <= b;

        public static Boolean operator >=(Double a, Fraction b) => a >= (Double)b;

        public static Boolean operator <=(Double a, Fraction b) => a <= (Double)b;

        public static Double operator %(Fraction a, Double b) => (Double)a % b;

        public static Double operator %(Double a, Fraction b) => a % (Double)b;
    }
}
