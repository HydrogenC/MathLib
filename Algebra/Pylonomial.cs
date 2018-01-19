using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Fraction;

namespace Algebra
{

    public partial class Pylonomial
    {
        private List<Monomial> moList = new List<Monomial>();
        private Fraction.Fraction pyCoefficient = (Fraction.Fraction)"1/1";

        public Pylonomial()
        {

        }

        public Pylonomial(String pylonomial)
        {
            const String pattern1 = @"^[+-](\d+)?[(]";
            const String pattern2 = @"[+-]\d+";
            const String pattern3 = @"[+-]\d{0,65536}[A-Za-z]?(\^\d+\^)?";
            const String pattern4 = @"[+-]";
            if (!(pylonomial.StartsWith("+") || pylonomial.StartsWith("-")))
            {
                pylonomial = "+" + pylonomial;
            }
            Match match = Regex.Match(pylonomial, pattern1);
            if(Regex.IsMatch(match.Value, pattern2))
            {
                pyCoefficient = Fraction.Fraction.Parse(Regex.Match(match.Value, pattern2).Value);
            }
            else
            {
                switch (Regex.Match(match.Value, pattern4).Value)
                {
                    case "+":
                        pyCoefficient = (Fraction.Fraction)1;
                        break;
                    case "-":
                        pyCoefficient = (Fraction.Fraction)(-1);
                        break;
                    default:
                        break;
                }
            }
            pylonomial=Regex.Replace(pylonomial, pattern1, "");
            pylonomial = pylonomial.Replace(")", "");
            if (!(pylonomial.StartsWith("+") || pylonomial.StartsWith("-")))
            {
                pylonomial = "+" + pylonomial;
            }
            MatchCollection matchCollection = Regex.Matches(pylonomial, pattern3);
            for(Int64 i = 0; i < matchCollection.Count; i += 1)
            {
                moList.Add(new Monomial(matchCollection[(Int32)i].Value));
            }
        }

        public Pylonomial(String pylonomial, Boolean positive)
        {
            pyCoefficient = (Fraction.Fraction)1;
            if (!(pylonomial.StartsWith("+") || pylonomial.StartsWith("-")))
            {
                pylonomial = "+" + pylonomial;
            }
            List<String> temp = new List<String>();
            Int64 previousOperator = 0;
            for (Int64 i = 1; i < pylonomial.Length; i += 1)
            {
                if (pylonomial[(Int32)i].Equals('+') || pylonomial[(Int32)i].Equals('-'))
                {
                    if (i - previousOperator >= 2)
                    {
                        temp.Add(pylonomial.Substring((Int32)previousOperator, (Int32)i - (Int32)previousOperator));
                        previousOperator = i;
                    }
                }
            }
            temp.Add(pylonomial.Substring((Int32)previousOperator, pylonomial.Length - (Int32)previousOperator));
            foreach (var i in temp)
            {
                moList.Add(new Monomial(i));
            }
        }

        public List<Monomial> Monomials
        {
            get => moList;
        }

        public override String ToString()
        {
            return ToString(false);
        }

        public String ToString(Boolean withSign, Boolean useFraction=false)
        {
            String temp = "";
            String coe="";
            if (useFraction)
            {
                coe = pyCoefficient.ToString();
            }
            else
            {
                if (pyCoefficient == 1)
                {
                    coe = "";
                }
                else
                {
                    coe = ((Int64)pyCoefficient).ToString();
                }
            }
            if (withSign)
            {
                if (IsPositive)
                {
                    temp = "+" + coe+"(";
                }
                else
                {
                    temp = coe + "(";
                }
            }
            else
            {
                temp = pyCoefficient + "(";
            }
            foreach (var i in moList)
            {
                temp += i.ToString(true,false,false);
            }
            temp += ")";
            return temp;
        }

        public Boolean IsPositive
        {
            get
            {
                if (pyCoefficient >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value)
                {
                    pyCoefficient = pyCoefficient.Abs();
                }
                else
                {
                    pyCoefficient = -pyCoefficient.Abs();
                }
            }
        }

        public Fraction.Fraction Coefficient {
            get => pyCoefficient;
            set => pyCoefficient = value;
        }

        public Fraction.Fraction AbsCoefficient
        {
            get => pyCoefficient.Abs();
        }
    }
}