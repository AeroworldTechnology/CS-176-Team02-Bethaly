// Program: Test case for Assignment #4a (MyMath)
// Description: Get our AContainsB to work as a method, then copy into MyMath
// Name: Andy Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Instructor: Brother Daniel Masterson
// Course: CS 176 - Windows Desktop Development

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AContainsB
{
    class Program
    {
        static bool AContainsB(string sA, string sB)
        {
            if (sA == sB)
            {
                WriteLine("The strings are the same.");
                return true;
            }
            else if (sA.Length < sB.Length)
            {
                WriteLine("The sub-string is longer than the test string.");
                return false;
            }
            else
            {
                int difference = (sA.Length - sB.Length);
                for (int i = 0; i < difference + 1; i++)
                {
                    if (sA.Substring(i, sB.Length) == sB)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            Write("Please enter a string to test against: ");
            string stringA = ReadLine();

            Write("Please enter a sub-string to test: ");
            string stringB = ReadLine();

            WriteLine();

            // Run the method and get a boolean result
            bool resultContains = AContainsB(stringA, stringB);

            Write("The test string does ");
            if (resultContains)
            {
                Write("");
            }
            else
            {
                Write("NOT ");
            }
            WriteLine("contain the check string.");

// TEST     WriteLine(resultContains);
            WriteLine();
            WriteLine("Press any key...");
            ReadLine();
        }
    }
}
