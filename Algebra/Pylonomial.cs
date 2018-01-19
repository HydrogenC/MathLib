using System;
using System.Collections.Generic;

namespace Algebra
{

    public partial class Pylonomial
    {
        private List<Monomial> moList = new List<Monomial>();
        private Boolean isPositive = true;

        public Pylonomial()
        {

        }

        public Pylonomial(String pylonomial)
        {
            if (!(pylonomial.StartsWith("+") || pylonomial.StartsWith("-")))
            {
                pylonomial = "+" + pylonomial;
            }
            if (pylonomial.StartsWith("+(") && pylonomial.EndsWith(")"))
            {
                pylonomial = pylonomial.Substring(2, pylonomial.Length - 3);
            }
            if (pylonomial.StartsWith("-(") && pylonomial.EndsWith(")"))
            {
                pylonomial = pylonomial.Substring(2, pylonomial.Length - 3);
                isPositive = false;
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

        public Pylonomial(String pylonomial, Boolean positive)
        {
            isPositive = positive;
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

        public String ToString(Boolean withSign)
        {
            String temp = "";
            if (withSign)
            {
                if (!isPositive)
                {
                    temp = "-(";
                }
                else
                {
                    temp = "+(";
                }
            }
            foreach (var i in moList)
            {
                temp += i.ToString(true);
            }
            if (withSign)
            {
                temp += ")";
            }
            return temp;
        }

        public Boolean IsPositive
        {
            get => isPositive;
            set => isPositive = value;
        }
    }
}