using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace xLib
{
    public class MonomialExpr : Expression
    {
        private double _a;
        private double _n;

        protected MonomialExpr(double a, double n)
        {
            _a = a;
            _n = n;
        }

        public override double Evaluate(double x)
        {
            return _a * Math.Pow(x, _n);
        }

        public override Expression Derive()
        {
            //return new MonomialExpr(_a * _n, _n - 1);
            return createObject(_a * _n, _n - 1);
        }

        public override string ToString()
        {
            return _a.ToString() + "x^" + _n.ToString();
        }

        [MethodImplAttribute(MethodImplOptions.Synchronized)] 
        public static Expression createObject(double a, double n)
        {
            if (a == 0 || n == 0)
            {
                return ConstExpr.createObject(a);
            }
            return new MonomialExpr(a, n);
        }
    }
}
