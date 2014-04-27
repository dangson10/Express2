using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xLib;
namespace Express2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1_______________________________________________________________________________");
            // (3*x^2 + 7) / (x + 5)   82 / 10 = 8.2
            Expression exp = new DivExpr(
                                new AddExpr(
                                    MonomialExpr.createObject(3, 2),
                                    ConstExpr.createObject(7)),
                                new AddExpr(
                                    MonomialExpr.createObject(1, 1),
                                    ConstExpr.createObject(5)));
          
            Console.WriteLine("f(x)=" + exp.ToString());
            Console.WriteLine("f(5)=" + exp.Evaluate(5));
            Console.WriteLine("f'(x)=" + exp.Derive().ToString());

            Console.WriteLine("2_______________________________________________________________________________");
            // (0 + 10) - 0 * (x^1 + 0)
            Expression exp5 = new AddExpr(MonomialExpr.createObject(0, 2),
                ConstExpr.createObject(10));

            Expression exp6 = new SubExpr(exp5,
                new MulExpr(ConstExpr.createObject(0), 
                    new AddExpr(MonomialExpr.createObject(1,1), 
                        ConstExpr.createObject(0))));

            Console.WriteLine("f(x)=" + exp6.ToString());
            Console.WriteLine("f(2)=" + exp6.Evaluate(2));
            Console.WriteLine("f'(x)=" + exp6.Derive().ToString());


            Console.WriteLine("3_______________________________________________________________________________");
            //(((x^2 + 2) / (x + 1)) + 10) / (x^2 + 5)
            Expression exp3 = new DivExpr(
                               new AddExpr(
                                   MonomialExpr.createObject(1, 2),
                                   ConstExpr.createObject(2)),
                               new AddExpr(
                                   MonomialExpr.createObject(1, 1),
                                   ConstExpr.createObject(1)));

            Expression exp4 = new DivExpr(
                              new AddExpr(
                                  exp3,
                                   ConstExpr.createObject(10)),
                              new AddExpr(
                                   MonomialExpr.createObject(1, 2),
                                   ConstExpr.createObject(5)));

            Console.WriteLine("f(x)=" + exp4.ToString());
            Console.WriteLine("f(1)=" + exp4.Evaluate(1));
            Console.WriteLine("f'(x)=" + exp4.Derive().ToString());
        }
    }
}
