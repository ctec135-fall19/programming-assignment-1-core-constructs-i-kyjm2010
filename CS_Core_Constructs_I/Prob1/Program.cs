﻿/*
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
            #endregion

            #region another code region
            // some code
            double a = new double();
            Console.WriteLine(a);
            #endregion
        }
    }
}
