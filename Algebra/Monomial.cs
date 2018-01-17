using System;
using System.Numerics;
using System.Collections.Generic;

namespace Algebra
{
    public class Monomial
    {
        private readonly List<Char> moLetters = new List<Char>();
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
            foreach (Char i in letters)
            {
                moLetters.Add(i);
            }
        }

        public Monomial(Fraction.Fraction coefficient, List<Char> letters)
        {
            moCoefficient = coefficient;
            moLetters = letters;
        }

        public Monomial(Fraction.Fraction coefficient, Char[] letters)
        {
            moCoefficient = coefficient;
            moLetters = new List<Char>(letters);
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

        public Char Operator
        {
            get
            {
                if (moCoefficient < (BigInteger)0)
                {
                    return '-';
                }
                else
                {
                    return '+';
                }
            }
            set
            {
                switch (value)
                {
                    case '+':
                        moCoefficient = moCoefficient.Abs();
                        break;
                    case '-':
                        moCoefficient = -moCoefficient.Abs();
                        break;
                    default:
                        throw new Exception("Invaild operator! ");
                }
            }
        }

        public String Value
        {
            get
            {
                String m = moCoefficient.ToString();
                foreach (var i in moLetters)
                {
                    m += i.ToString();
                }

                return m;
            }
        }

        public List<Char> Letters
        {
            get => moLetters;
        }
    }
}