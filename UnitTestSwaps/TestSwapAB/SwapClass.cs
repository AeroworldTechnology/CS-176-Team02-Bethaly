// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test SwapAandB
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwapAB
{
    public class SwapClass
    {
     public static int SwapAandB(int firstValue, int secondValue)
        {
            WriteLine();
            WriteLine("You entered {0} for the first value, and {1} for the second value", firstValue, secondValue);

            // Perform a three-way swap of variables
            int swapValue = firstValue;
            firstValue = secondValue;
            secondValue = swapValue;

            WriteLine();
            WriteLine("Now, {0} is the first value, and {1} is the second value", firstValue, secondValue);
            return firstValue;
        }
    }
}
