using System;
using System.Collections.Generic;

namespace Algebra
{
    /// <summary>
    /// Use x^2^ to express x²
    /// </summary>
    public class Monomial
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
                moLetters.Add(new Letter(i));
            }
        }

        public Monomial(Fraction.Fraction coefficient, List<Char> letters)
        {
            moCoefficient = coefficient;
            foreach(var i in letters)
            {
                moLetters.Add(new Letter(i));
            }
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

        public Char Operator
        {
            get
            {
                if (moCoefficient < (Int64)0)
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

        public String ValueWithSign
        {
            get
            {
                String m = moCoefficient < 0 ? "-" : "+";
                if ((Decimal)moCoefficient % 1 == 0)
                {
                    m += (Int64)(Double)moCoefficient;
                }
                else
                {
                    m += "("+moCoefficient.ToString()+")";
                }
                foreach (var i in moLetters)
                {
                    m += i.ToString();
                }

                return m;
            }
        }

        public List<Letter> Letters
        {
            get => moLetters;
        }

        public List<Char> CharLetters
        {
            get
            {
                List<Char> m = new List<Char>();
                foreach(var i in moLetters)
                {
                    m.Add(i.GetLetter);
                }
                return m;
            }
        }
    }
}