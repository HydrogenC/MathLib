using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    partial class Product
    {
        private void CheckIsPositive()
        {
            Int64 numberOfNegative = 0;
            foreach(var i in pList)
            {
                if (!i.IsPositive)
                {
                    i.IsPositive = true;
                    numberOfNegative += 1;
                }
            }
            foreach (var i in mList)
            {
                if (!i.IsPositive)
                {
                    i.IsPositive = true;
                    numberOfNegative += 1;
                }
            }
            if (numberOfNegative % 2 == 0)
            {
                return;
            }
            else
            {
                isPositive = !isPositive;
            }
        }
    }
}
