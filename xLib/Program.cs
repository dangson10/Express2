using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // (3*x^2 + 7) / (x + 5)   82 / 10 = 8.2
            //Expression exp = new DivExpr(
            //                    new AddExpr(
            //                        new MonomialExpr(3, 2),
            //                        new ConstExpr(7)),
            //                    new AddExpr(
            //                        new MonomialExpr(1, 1),
            //                        new ConstExpr(5)));

            //double result = exp.Evaluate(5);
            //Expression exp2 = exp.Derive();

            //Console.WriteLine(result);
            //Console.WriteLine("f(x)=" + exp.ToString());
            //Console.WriteLine("f'(x)=" + exp2.ToString());


            //Expression exp3 = new DivExpr(
            //                      new AddExpr(
            //                          new MonomialExpr(1, 2),
            //                          new ConstExpr(2)),
            //                      new AddExpr(
            //                          new MonomialExpr(1, 1),
            //                          new ConstExpr(1)));
            //Expression exp4 = new DivExpr(
            //                  new AddExpr(
            //                      exp3,
            //                      new ConstExpr(10)),
            //                  new AddExpr(
            //                      new MonomialExpr(1, 2),
            //                      new ConstExpr(5)));
            //Console.WriteLine(exp4.ToString());

            //Expression expResult = exp4.Derive();
            //Console.WriteLine(expResult.ToString());

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
            Console.WriteLine(exp4.ToString());

            Expression expResult = exp4.Derive();
            Console.WriteLine(expResult.ToString());
        }
    }
}
