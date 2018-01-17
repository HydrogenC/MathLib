using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    public partial class Pylonomial
    {
        public void ChangeSign()
        {
            if (pylonomialOperator)
            {
                pylonomialOperator = PylomialOperator.Minus;
            }
            else
            {
                pylonomialOperator = PylomialOperator.Plus;
            }
            foreach(var i in moList)
            {
                i.Coefficient = -i.Coefficient;
            }
        }
    }
}
