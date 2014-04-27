using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public abstract class BinaryExpr : Expression
    {
        protected Expression _expr1;
        protected Expression _expr2;
        private Expression cache = null;
        public BinaryExpr(Expression e1, Expression e2)
        {
            _expr1 = e1;
            _expr2 = e2;
        }

        public abstract override double Evaluate(double x);
        protected abstract Expression createDerive();
        public override Expression Derive()
        {
            if (cache == null)
                cache = this.createDerive();
            return cache;
        }
    }
}
