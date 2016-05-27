// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 23 May 2016
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
    class Program
    {
        static void Main(string[] args)
        {
        MainMenu:
            Clear();
            WriteLine("Please select a function:");
            WriteLine("1. Sum of integers");
            WriteLine("2. A Contains B");
            WriteLine("3. Swap A and B  [done]");
            WriteLine("4. A to the power of B  [done]");
            WriteLine("5. Password Verification [done]");
            WriteLine("9. Unit Tests");
            WriteLine("0. EXIT");
            string menuSelection = ReadLine();

            switch (Convert.ToInt16(menuSelection))
            {
                case 1:
                   // "1. A function that takes an array of integer and returns the sum of the integers."
                    WriteLine("Please enter the lenght of an array of integer");

                    String input = ReadLine();
                    int lenght = Convert.ToInt32(input);
                    int[] inputValue = { };

                    WriteLine("Please enter integers at a time and press Enter");

                    int resultSum = SumOfIntegers(inputValue);
                    WriteLine("The result is" + resultSum);

                    break;
                case 2:
                    // "2. A function that given two strings returns true or false depending on if the second string is in the first string."

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

                    int swapResult = SwapAandB(firstValue, secondValue);

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
                case 9:
                    // "Write unit tests for each of these functions. You will be expected to demo your unit tests on the due date in class."
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

        public static int SumOfIntegers(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                string input2 = ReadLine();
                int numbers = Convert.ToInt16(input2);

                array[i] = numbers;
                result += numbers;
            }

            return result;
        }
        public bool AContainsB(int numberA, int numberB)
        {
            // Test if B is longer than A [fail]

            // Loop through A to test each substring
            // Make sure to loop from 0 thru (A.Length - B.Length)

            // If B = substring of A, return true;
            if (true)
            {
                return true;
            }

            // If loop finishes without a return true, then return false
            return false;
        }

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
            return 0;
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
