using System;
using System.Collections.Generic;

namespace Algebra
{
    public class Product
    {
        Boolean isPositive = true;
        List<Monomial> mList = new List<Monomial>();
        List<Pylonomial> pList = new List<Pylonomial>();
        public Product()
        {

        }

        public Product(Monomial monomial)
        {
            mList.Add(monomial);
        }

        public Product(Pylonomial pylonomial)
        {
            pList.Add(pylonomial);
        }

        public void Add(Monomial monomial)
        {
            mList.Add(monomial);
        }

        public void Add(Pylonomial pylonomial)
        {
            pList.Add(pylonomial);
        }

        public List<Pylonomial> PylonomialList
        {
            get => pList;
        }

        public List<Monomial> MonomialList
        {
            get => mList;
        }

        public override String ToString()
        {
            return ToString(false);
        }

        public String ToString(Boolean withSign)
        {
            String temp = "";
            if (isPositive&&withSign)
            {
                temp = "+";
            }
            if (!isPositive)
            {
                temp = "-";
            }
            foreach (var i in mList)
            {
                temp += i.ToString(false);
            }
            foreach (var i in pList)
            {
                temp += "(" + i.Value + ")";
            }
            return temp;
        }

        public Boolean IsPositive {
            get => isPositive;
            set => isPositive = value;
        }
    }
}
