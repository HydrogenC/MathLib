using System;
using System.Collections.Generic;

namespace Algebra
{
    /// <summary>
    /// Use x^2^ to express x²
    /// </summary>
    public partial class Monomial
    {
        private readonly List<Letter> moLetters = new List<Letter>();
        private Fraction.Fraction moCoefficient;

        public Monomial()
        {
        }

        public Monomial(String monomial)
        {
            if (monomial.Length > 0)
            {
                if (Functions.ContainsLetters(monomial))
                {
                    if (!(monomial.StartsWith("+") || monomial.StartsWith("-")))
                    {
                        monomial = "+" + monomial;
                    }
                    moCoefficient = Functions.OutputNumbers(monomial, ref moLetters);
                }
                else
                {
                    Decimal temp = Decimal.Parse(monomial);
                    if (temp != 0)
                    {
                        moCoefficient = temp;
                    }
                }
            }
            else
            {
                throw new Exception("Try to use Monomial()! ");
            }
        }

        public Monomial(Fraction.Fraction coefficient, String letters)
        {
            moCoefficient = coefficient;
            moLetters = Functions.OutputNumbers(letters);
        }

        public Monomial(Fraction.Fraction coefficient, List<Letter> list)
        {
            moCoefficient = coefficient;
            moLetters = new List<Letter>(list);
        }

        public Fraction.Fraction AbsCoefficient
        {
            get => moCoefficient.Abs();
        }

        public Fraction.Fraction Coefficient
        {
            get => moCoefficient;
            set => moCoefficient = value;
        }

        public override String ToString()
        {
            return ToString(false, false);
        }

        public String ToString(Boolean containsSign, Boolean useFraction = false)
        {
            String temp = "";
            if (useFraction)
            {
                temp += moCoefficient.ToString();
            }
            else
            {
                temp+=((Decimal)moCoefficient).ToString();
            }
            if (containsSign && (!temp.StartsWith("-"))) 
            {
                temp = "+" + temp;
            }
            foreach (var i in moLetters)
            {
                if (i.Exponent == 1)
                {
                    temp += i.GetLetter;
                }
                else
                {
                    temp += i.GetLetter + Arithmetic.IntegerFunctions.ToSuperscript(i.Exponent.ToString());
                }
            }
            return temp;
        }

        public List<Letter> Letters
        {
            get => moLetters;
        }

        public String ToStringNoCoefficient
        {
            get
            {
                String temp = "";
                foreach (var i in moLetters)
                {
                    if (i.Exponent == 1)
                    {
                        temp += i.GetLetter;
                    }
                    else
                    {
                        temp += i.GetLetter + Arithmetic.IntegerFunctions.ToSuperscript(i.Exponent.ToString());
                    }
                }
                return temp;
            }
        }

        public Boolean IsPositive
        {
            get
            {
                if (moCoefficient >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}