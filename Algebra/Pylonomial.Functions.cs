using System;

namespace Algebra
{
    public partial class Pylonomial
    {
        public void ChangeSign()
        {
            if (isPositive)
            {
                isPositive = false;
            }
            else
            {
                isPositive = true;
            }
            foreach (var i in moList)
            {
                i.Coefficient = -(i.Coefficient);
                i.Coefficient.Adjust();
            }
        }
    }
}
