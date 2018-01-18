using System;
using System.Collections.Generic;

namespace Algebra
{
    public class PylomialOperator
    {
        public static Boolean Plus
        {
            get => true;
        }
        public static Boolean Minus
        {
            get => false;
        }
    }

    public partial class Pylonomial
    {
        private List<Monomial> moList = new List<Monomial>();
        private Boolean pylonomialOperator = PylomialOperator.Plus;

        public Pylonomial()
        {

        }

        public Pylonomial(String pylonomial)
        {
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

        

        public String Value
        {
            get
            {
                String temp = "";
                if (!pylonomialOperator)
                {
                    ChangeSign();
                }
                foreach (var i in moList)
                {
                    temp += i.ToString(true);
                }
                return temp;
            }
        }
    }
}