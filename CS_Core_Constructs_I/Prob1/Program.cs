/*
Author: <your name>
Date:   <date>
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example of a code region
            // some code
            double i = 20;
            System.Double d = 9;
            Console.WriteLine(i);
            Console.WriteLine(d);
            double a = new double();
            Console.WriteLine(a);
            #endregion

            #region another code region
            // some code
            byte s = 250;
            short v = 32_700;
            int myInt = 30;
            long g = 9_000_000_000;
            float t = 5.3F;
            double k = 300.5;
            decimal b = 7.98274M;
            Console.WriteLine("byte: {0} \nshort:{1} \nint:{2} \nlong:{3} \nfloat:{4} \ndouble:{5} \ndecimal:{6}" , s, v, myInt, g, t, k, b);
            #endregion

            #region yet another code region
            long[] array1 = {0, 20, 9, 250, 32_700, 30, 9_000_000_000, 5, 300, 8};
            Console.WriteLine("The maximum value in the array provided is:{0}",array1.Max());
            Console.WriteLine("The minimum value in the array provided is:{0}",array1.Min());

            #endregion
        }
    }
}
