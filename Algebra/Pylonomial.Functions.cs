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
            foreach(var i in pylonomial.Monomials)
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
    }
}
