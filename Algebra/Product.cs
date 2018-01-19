using System;
using System.Collections.Generic;

namespace Algebra
{
    public partial class Product
    {
        Fraction.Fraction prCofficient = (Fraction.Fraction)1;
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
            Extract();
        }

        public Product(Pylonomial pylonomial)
        {
            pList.Add(pylonomial);
            Extract();
        }

        public void Add(Monomial monomial)
        {
            mList.Add(monomial);
            Extract();
        }

        public void Add(Pylonomial pylonomial)
        {
            pList.Add(pylonomial);
            Extract();
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
            if (IsPositive&&withSign)
            {
                temp = "+";
            }
            temp += prCofficient;
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
            get
            {
                if (prCofficient >= 0)
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
                    prCofficient = prCofficient.Abs();
                }
                else
                {
                    prCofficient = -prCofficient.Abs();
                }
            }
        }
    }
}
