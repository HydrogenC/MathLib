using System;

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
            foreach (var i in moList)
            {
                i.Coefficient = -(i.Coefficient);
                i.Coefficient.Adjust();
            }
        }
    }
}
