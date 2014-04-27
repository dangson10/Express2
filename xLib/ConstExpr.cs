using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace xLib
{
    public class ConstExpr : Expression
    {
        private static ConstExpr ZERO = null;
        private double _value;
        
        protected ConstExpr(double value)
        {
            this._value = value;
        }
        public override Expression Derive()
        {
            return new ConstExpr(0);
        }
        public override string ToString()
        {
            return this._value.ToString();
        }
        public override double Evaluate(double x)
        {
            return _value;
        }

        [MethodImplAttribute(MethodImplOptions.Synchronized)] 
        public static Expression createObject(double value)
        {
            if (value == 0)
            {
                ConstExpr.getZero();
            }
            return new ConstExpr(value);
        }
        public static ConstExpr getZero()
        {
            if (ZERO == null)
                ZERO = new ConstExpr(0);
            return ZERO;
        }
    }
}
