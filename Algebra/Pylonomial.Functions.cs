using System;

namespace Algebra
{
    public partial class Pylonomial
    {
        public void ChangeSign()
        {
            if (IsPositive)
            {
                IsPositive = false;
            }
            else
            {
                IsPositive = true;
            }
            foreach (var i in moList)
            {
                i.Coefficient = -(i.Coefficient);
                i.Coefficient.Adjust();
            }
        }

        public void Add(Monomial monomial)
        {
            moList.Add(monomial);
        }

        public void Add(String str)
        {
            Pylonomial pylonomial = new Pylonomial(str);
            foreach (var i in pylonomial.Monomials)
            {
                moList.Add(i);
            }
        }

        public void Add(Pylonomial pylonomial)
        {
            foreach (var i in pylonomial.Monomials)
            {
                moList.Add(i);
            }
        }

        private void Extract()
        {
            Int64 gcd = Arithmetic.IntegerFunctions.GetLCMGCD((Int64)moList[0].AbsCoefficient, (Int64)moList[1].AbsCoefficient, Arithmetic.IntegerFunctions.GCD);
            for (Int64 i = 2; i < moList.Count; i += 1)
            {
                gcd = Arithmetic.IntegerFunctions.GetLCMGCD(gcd, (Int64)moList[(Int32)i].AbsCoefficient, Arithmetic.IntegerFunctions.GCD);
            }
            foreach(var i in moList)
            {
                i.Coefficient /= gcd;
            }
        }
    }
}
