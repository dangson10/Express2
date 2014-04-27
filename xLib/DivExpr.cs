using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public class DivExpr : BinaryExpr
    {
        public DivExpr(Expression e1, Expression e2)
            : base(e1, e2)
        {
        }

        public override double Evaluate(double x)
        {
            return base._expr1.Evaluate(x) /
                   base._expr2.Evaluate(x);
        }

        protected override Expression createDerive()
        {
            return new DivExpr
                (
                new SubExpr
                    (
                    new MulExpr
                        (
                        base._expr1.Derive(),
                        base._expr2
                        ),
                    new MulExpr
                        (
                        base._expr1,
                        base._expr2.Derive()
                        )
                    ),
                new MulExpr(_expr2, _expr2)
                );

        }

        public override string ToString()
        {
            return  "(" +  _expr1.ToString()  + ") / ("  + _expr2.ToString() + ")";
        }
    }
}
