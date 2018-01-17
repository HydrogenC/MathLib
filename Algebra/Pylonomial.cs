using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace Algebra
{
    public class Pylonomial
    {
        private List<Monomial> moList=new List<Monomial>();

        public Pylonomial()
        {
            
        }

        public Pylonomial(String pylonomial)
        {
            if (!(pylonomial.StartsWith("+") || pylonomial.StartsWith("-")))
            {
                pylonomial = "+" + pylonomial;
            }
            List<String> temp=new List<String>();
            BigInteger previousOperator = 0;
            for (BigInteger i = 1; i < pylonomial.Length; i += 1)
            {
                if (pylonomial[(Int32) i].Equals('+')||pylonomial[(Int16) i].Equals('-'))
                {
                    if (i - previousOperator >= 2)
                    {
                        temp.Add(pylonomial.Substring((Int16) previousOperator, (Int16) i - (Int16) previousOperator));
                        previousOperator = i;
                    }
                }
            }
            temp.Add(pylonomial.Substring((Int16) previousOperator, pylonomial.Length - (Int16) previousOperator));
            foreach (var i in temp)
            {
                moList.Add(new Monomial(i));
            }
        }

        public List<Monomial> Monomials
        {
            get => moList;
        }

        public BigInteger Round()
        {
            for (BigInteger i = 1;; i += 1)
            {
                Boolean isInteger = true;
                foreach (var j in Monomials)
                {
                    if (((Decimal)i * (Decimal)j.Coefficient) % 1 != 0)
                    {
                        isInteger = false;
                    }
                }

                if (isInteger)
                {
                    foreach (var j in Monomials)
                    {
                        j.Coefficient *= i;
                    }
                    return i;
                }
            }
        }
    }
}