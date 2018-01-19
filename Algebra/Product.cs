using System;
using System.Collections.Generic;

namespace Algebra
{
    public partial class Product
    {
        Boolean isPositive = true;
        List<Monomial> mList = new List<Monomial>();
        List<Pylonomial> pList = new List<Pylonomial>();

        /// <summary>
        /// Create an empty Product instance. 
        /// </summary>
        public Product()
        {

        }

        /// <summary>
        /// Initial the Product with a monomial. 
        /// </summary>
        /// <param name="monomial">The monomial to initial with. </param>
        public Product(Monomial monomial)
        {
            mList.Add(monomial);
            CheckIsPositive();
        }

        public Product(Pylonomial pylonomial)
        {
            pList.Add(pylonomial);
            CheckIsPositive();
        }

        public void Add(Monomial monomial)
        {
            mList.Add(monomial);
            CheckIsPositive();
        }

        public void Add(Pylonomial pylonomial)
        {
            pList.Add(pylonomial);
            CheckIsPositive();
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
                temp += "(" + i.ToString() + ")";
            }
            return temp;
        }

        public Boolean IsPositive {
            get => isPositive;
            set => isPositive = value;
        }
    }
}
