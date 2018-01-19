using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        public Product(String product)
        {
            if (!(product.StartsWith("+") || product.StartsWith("-")))
            {
                product = "+" + product;
            }
            const String regex1 = @"[+-]\d{0,65536}[A-Za-z]{0,65536}([(]([+-]?\d[A-Za-z]{0,65536})+[)]){0,65536}";
            const String regex2= @"[(]([+-]?\d[A-Za-z]{0,65536})+[)]";
            const String regex3 = @"[+-]\d{0,65536}[A-Za-z]{0,65536}";
            const String regex4 = @"([+-]?\d[A-Za-z]{0,65536})+";
            if (Regex.IsMatch(product, regex1))
            {
                MatchCollection matchCollection = Regex.Matches(product, regex2);
                for (Int64 i = 0; i < matchCollection.Count; i += 1) 
                {
                    Match match1 = Regex.Match(matchCollection[(Int32)i].Value, regex4);
                    pList.Add(new Pylonomial(match1.Value));
                }
                Match match = Regex.Match(product, regex3);
                mList.Add(new Monomial(match.Value));
            }
            else
            {
                throw new Exception("Wrong format! ");
            }
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

        public String ToString(Boolean withSign, Boolean useFraction = false)
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
                temp += "(" + i.ToString(true,false) + ")";
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
