// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 03 Jun 2016
// Description: 
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu:
            Clear();
            WriteLine("Please select a function:");
            WriteLine("1. Sum of integers");
            WriteLine("2. A Contains B");
            WriteLine("3. Swap A and B");
            WriteLine("4. A to the power of B");
            WriteLine("5. Password Verification");
            WriteLine("0. EXIT");
            string menuSelection = ReadLine();

            switch (Convert.ToInt16(menuSelection))
            {
                case 1:
                    // "1. A function that takes an array of integer and returns the sum of the integers."
                    WriteLine("Please enter an array of integers:");
                    WriteLine("Enter zero (0) to stop the array.");
                    int[] inputArray = new int[30];

                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        inputArray[i] = Convert.ToInt32(ReadLine());

                        WriteLine(inputArray[i]);
                        if (inputArray[i] == 0)
                        {
                            break;
                        }
                    }

                    int resultSum = SumOfIntegers(inputArray);
                    WriteLine("The result is " + resultSum);
                    break;
                case 2:
                    // "2. A function that given two strings returns true or false depending on if the second string is in the first string."

                    WriteLine("Please enter the string to check against: ");
                    string stringA = ReadLine();

                    WriteLine("Please enter the sub-string: ");
                    string stringB = ReadLine();

                    bool searchResult = AContainsB(stringA, stringB);

                    Write("The check string does ");
                    if (searchResult)
                    {
                        Write("");
                    }
                    else
                    {
                        Write("NOT ");
                    }
                    WriteLine("contain the sub-string.");
                    break;
                case 3:
                    // "3. A function that given two integers swaps the value of the two integers."
                    //DONE

                    Write("Please enter the first integer: ");
                    string firstEntry = ReadLine();
                    int firstValue = Convert.ToInt16(firstEntry);

                    Write("Please enter the second integer: ");
                    string secondEntry = ReadLine();
                    int secondValue = Convert.ToInt16(secondEntry);

                    int[] swapResult = SwapAandB(firstValue, secondValue);

                    break;
                case 4:
                    // "4. Write the power function, x^n.This function takes an integer and raises it to a second integer."

                    Write("Please enter the \"X\" integer: ");
                    string xEntry = ReadLine();
                    int xValue = Convert.ToInt16(xEntry);

                    Write("Please enter the \"n\" integer: ");
                    string nEntry = ReadLine();
                    int nValue = Convert.ToInt16(nEntry);

                    int calcValue = AtoPowerB(xValue, nValue);

                    WriteLine();
                    WriteLine("{0} raised to the power of {1} is {2}", xValue, nValue, calcValue);
                    break;
                case 5:
                    // "5. Write a function that given a password checks it to see if it is in the right format and returns true or false. The password must have at least 8 characters, one character must be a capitalized letter, one character must be a special character and one character must be a digit."

                    GetPasswordFromUser:
                    WriteLine();
                    WriteLine("The pasword should have at least one uppercase chacter, one special character, one number character, onw lowercase letter, and should be at least 8 characters in length.");
                    WriteLine("Please enter a new password: ");
                    string userEntry = ReadLine();

                    bool result = PasswordCheck(userEntry);

                    if (result)
                    {
                        WriteLine();
                        WriteLine("Thank you.  The password does meet the qualifications.");
                    }
                    else
                    {
                        WriteLine();
                        WriteLine("The password did not meet the qualifications.");
                        goto GetPasswordFromUser;
                    }
                    break;
                default:
                    goto Exit;
            }
            WriteLine();
            WriteLine("Please any key to continue...");
            ReadKey();
            goto MainMenu;
            Exit: { }
        }

        public static int SumOfIntegers(int[] inputArray)
        {
            int result = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                result += inputArray[i];
            }
            return result;
        }

        public static bool AContainsB(string stringA, string stringB)
        {
            // Loop through A to test each substring
            // Make sure to loop from 0 thru (A.Length - B.Length)

            // If B = substring of A, return true;
            // If loop finishes without a return true, then return false
            // Test if B is the same as A [fail]
            bool contain = true;
            if (stringA == stringB)
            {
                WriteLine("Both strings are the same.");
                return false;
            }
            // Test if B is longer than A [fail]
            else if (stringA.Length < stringB.Length)
            {
                WriteLine("The sub-string is larger than the string being checked against.");
                return false;
            }

            else if (stringA.Length > stringB.Length)
            {
                int difference = stringA.Length - stringB.Length;

                for (int i = 0; i < difference + 1; i++)
                {
                    if (stringA.Substring(i, stringB.Length) == stringB)
                    {
                        WriteLine("Does contain {0} at position {1}. (index {2})", stringB, i + 1, i);
                        WriteLine("{0}[{1}]{2}", stringA.Substring(0, i), stringB, stringA.Substring(i + stringB.Length));
                        return contain = true;
                    }
                    else
                    {
                        contain = false;
                    }
                }
            }
            return contain;
        }

        public static int[] SwapAandB(int firstValue, int secondValue)
        {
            WriteLine();
            WriteLine("You entered {0} for the first value, and {1} for the second value", firstValue, secondValue);

            // Perform a three-hand swap of variables
            int swapValue = firstValue;
            firstValue = secondValue;
            secondValue = swapValue;

            WriteLine();
            WriteLine("Now, {0} is the first value, and {1} is the second value", firstValue, secondValue);
            int[] swapResult = { firstValue, secondValue };
            return swapResult;
        }

        public static int AtoPowerB(int xValue, int nValue)
        {
            int calcValue = 1;

            if (xValue != 0 && nValue != 0)
            {
                for (int i = 0; i < nValue; i++)
                {
                    calcValue = calcValue * xValue;
                }
            }
            else
            {
                if (xValue == 0)
                {
                    // Zero to any power is always zero, except...
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

        public static bool PasswordCheck(string userEntry)
        {
            // Quick check of length of entered password
            if (userEntry.Length < 8)
            {
                return false;
            }

            string validLettersSmall = "abcdefghijklmnopqrstuvwxyz";
            string validLettersCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string validSpecialChar = "`~!@#$%^&*()_-+={[}]:;\"\'<,>.?/|\\";
            string validDigits = "0123456789";
            int countSmall = 0;
            int countCaps = 0;
            int countChar = 0;
            int countDigits = 0;

            for (int i = 0; i < userEntry.Length; i++)
            {
                for (int j = 0; j < validLettersSmall.Length; j++)
                {
                    if (userEntry[i] == validLettersSmall[j])
                    {
                        countSmall++;
                    }
                }
                for (int j = 0; j < validLettersCaps.Length; j++)
                {
                    if (userEntry[i] == validLettersCaps[j])
                    {
                        countCaps++;
                    }
                }
                for (int j = 0; j < validSpecialChar.Length; j++)
                {
                    if (userEntry[i] == validSpecialChar[j])
                    {
                        countChar++;
                    }
                }
                for (int j = 0; j < validDigits.Length; j++)
                {
                    if (userEntry[i] == validDigits[j])
                    {
                        countDigits++;
                    }
                }
            }
            if (countSmall == 0 || countCaps == 0 || countChar == 0 || countDigits == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
