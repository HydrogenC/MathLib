using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    partial class Product
    {
        private void Extract()
        {
            foreach(var i in pList)
            {
                prCofficient *= i.Coefficient;
                i.Coefficient = (Fraction.Fraction)1;
            }

            foreach (var i in mList)
            {
                prCofficient *= i.Coefficient;
                i.Coefficient = (Fraction.Fraction)1;
            }

            prCofficient.Adjust();
        }
    }
}
