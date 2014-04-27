using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public class AddExpr : BinaryExpr
    {
        public AddExpr(Expression e1, Expression e2)
            : base(e1, e2)
        {
        }

        public override double Evaluate(double x)
        {
            return base._expr1.Evaluate(x) +
                   base._expr2.Evaluate(x);
        }

        protected override Expression createDerive()
        {
 	        return new AddExpr(base._expr1.Derive(),
                                       base._expr2.Derive());
        }

        public override string ToString()
        {
            return "(" + this._expr1.ToString() + " + " + _expr2.ToString() + ")";
        }
    }
}
