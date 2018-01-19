using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    partial class Monomial
    {
        public Monomial Abs() => new Monomial(AbsCoefficient, Letters);
    }
}
