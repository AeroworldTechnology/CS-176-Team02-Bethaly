// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test: Method AContainsB
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_AContainsB

{
    public class test_AContainsB
    {
        //Method to find if the string B is in string A
        public static bool AContainsB(string sA, string sB)
        {
            //if they are the same
            if (sA == sB)
            {
                WriteLine("The strings are the same.");
                return true;
            }
            //String B is bigger than String A
            else if (sA.Length < sB.Length)
            {
                WriteLine("The sub-string is longer than the test string.");
                return false;
            }
            else
            {
               //it is a for loop to find if stringB is in stringA through a substring
                int difference = (sA.Length - sB.Length);
                for (int i = 0; i < difference + 1; i++)
                {
                    //it will find if the substring is there
                    if (sA.Substring(i, sB.Length) == sB)
                    {
                        //it will return true 
                        return true;
                    }
                }
                
                return false;
            }
        }
    }
}
