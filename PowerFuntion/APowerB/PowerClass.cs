// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test: Method AtoPowerB
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_APowerB
{
    public class PowerClass
    {
        //This method will take a number and power to other number
        public static int AtoPowerB(int xValue, int nValue)
        {
            int calcValue = 1;

            if (xValue != 0 && nValue != 0)
            {
                //This for-loop will multiplicated the number A itself according to the number B  
                for (int i = 0; i < nValue; i++)
                {
                    calcValue = calcValue * xValue;
                }
            }
            else
            {
                if (xValue == 0)
                {
                    // Zero to any power is always zero
                    calcValue = 0;
                }
                if (nValue == 0)
                {
                    // Any number raised to zero power is 1, including zero.
                    calcValue = 1;
                }
            }
            return calcValue;
        }
    }
}
