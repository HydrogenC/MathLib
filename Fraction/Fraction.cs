using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public partial class Fraction
    {
        private Int64 denominator=1;
        //The sign symbol is only stored in Numerator
        private Int64 numerator=0;
        public Fraction()
        {
            
        }
        public Fraction(Int64 numer, Int64 deno)
        {
            numerator = numer;
            denominator = deno;
            Adjust();
            Reduct();
        }
        public Fraction(Fraction numer, Fraction deno)
        {
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(numer.Denominator, deno.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = numer.Numerator * (lcm / numer.Denominator);
            denominator = deno.Numerator * (lcm / deno.Denominator);
            Adjust();
            Reduct();
        }
        public Fraction(Fraction numer, Int64 deno)
        {
            denominator = deno * numer.Denominator;
            numerator = numer.Numerator;
            Adjust();
            Reduct();
        }
        public Fraction(Int64 numer, Fraction deno)
        {
            denominator = deno.Numerator;
            numerator = numer * deno.Denominator;
            Adjust();
            Reduct();
        }

        public Fraction(Decimal numer, Int64 deno)
        {
            Fraction temp = numer;
            denominator = deno * temp.Denominator;
            numerator = temp.Numerator;
            Adjust();
            Reduct();
        }

        public Fraction(Int64 numer, Decimal deno)
        {
            Fraction temp = deno;
            denominator = temp.Numerator;
            numerator = numer * temp.Denominator;
            Adjust();
            Reduct();
        }

        public Fraction(Double numer, Int64 deno)
        {
            Fraction temp = numer;
            denominator = deno * temp.Denominator;
            numerator = temp.Numerator;
            Adjust();
            Reduct();
        }

        public Fraction(Int64 numer, Double deno)
        {
            Fraction temp = deno;
            denominator = temp.Numerator;
            numerator = numer * temp.Denominator;
            Adjust();
            Reduct();
        }

        public Fraction(Decimal numer, Decimal deno)
        {
            Fraction t1 = numer;
            Fraction t2 = deno;
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(t1.Denominator, t2.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = t1.Numerator * (lcm / t1.Denominator);
            denominator = t2.Numerator * (lcm / t2.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Double numer,Double deno)
        {
            Fraction t1 = numer;
            Fraction t2 = deno;
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(t1.Denominator, t2.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = t1.Numerator * (lcm / t1.Denominator);
            denominator = t2.Numerator * (lcm / t2.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Decimal numer, Fraction deno)
        {
            Fraction t1 = numer;
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(t1.Denominator, deno.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = t1.Numerator * (lcm / t1.Denominator);
            denominator = deno.Numerator * (lcm / deno.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Fraction numer, Decimal deno)
        {
            Fraction t2 = deno;
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(numer.Denominator, t2.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = numer.Numerator * (lcm / numer.Denominator);
            denominator = t2.Numerator * (lcm / t2.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Double numer, Fraction deno)
        {
            Fraction t1 = numer;
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(t1.Denominator, deno.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = t1.Numerator * (lcm / t1.Denominator);
            denominator = deno.Numerator * (lcm / deno.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Fraction numer, Double deno)
        {
            Fraction t2 = deno;
            Int64 lcm = Arithmetic.IntegerFunctions.GetLCMGCD(numer.Denominator, t2.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = numer.Numerator * (lcm / numer.Denominator);
            denominator = t2.Numerator * (lcm / t2.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(String frac)
        {
            for (Int64 i = 0; i < frac.Length; i += 1)
            {
                if (frac[(Int32)i] == '/')
                {
                    numerator = Int64.Parse(frac.Substring(0, (Int32)i));
                    denominator = Int64.Parse(frac.Substring((Int32)i + 1));
                    break;
                }
                if (i == frac.Length - 1)
                {
                    try
                    {
                        numerator = Int64.Parse(frac);
                    }
                    catch (Exception e)
                    {
                        numerator = 1;
                    }
                    denominator = 1;
                }
            }
            Adjust();
            Reduct();
        }

        public Fraction(Decimal number)
        {
            Decimal multiplier = 1;
            while (true)
            {
                if (number * multiplier % 1 == 0)
                {
                    numerator = (Int64)(number * multiplier);
                    denominator = (Int64)multiplier;
                    break;
                }
                else
                {
                    multiplier *= 10;
                }
            }
            Reduct();
        }

        public Fraction(Int64 number)
        {
            numerator = number;
            denominator = 1;
        }

        public Fraction(Double number)
        {
            Double multiplier = 1;
            while (true)
            {
                if (number * multiplier % 1 == 0)
                {
                    numerator = (Int64)(number * multiplier);
                    denominator = (Int64)multiplier;
                    break;
                }
                else
                {
                    multiplier *= 10;
                }
            }
            Reduct();
        }

        public Int64 Numerator
        {
            get => numerator;
            set
            {
                numerator = value;
                Reduct();
            }
        }
        public Int64 Denominator
        {
            get => denominator;
            set
            {
                denominator = value;
                Adjust();
                Reduct();
            }
        }
    }
}
