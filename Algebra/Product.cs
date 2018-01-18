using System;
using System.Collections.Generic;

namespace Algebra
{
    class Product
    {
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

        public String Value
        {
            get
            {
                String temp = "";
                return temp;
            }
        }
    }
}
