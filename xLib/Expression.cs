using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public abstract class Expression
    {
        public abstract double Evaluate(double x);
        public abstract Expression Derive();
        public abstract string toString(IPrintExpr print);
    }
}
