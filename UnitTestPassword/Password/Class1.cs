// Project: Assignment #4
// Name: Andy E. Wold and Bethaly Tenango
// Date: 01 Jun 2016
// Description: Unit Test: Method PasswordCheck
// Instructor: Bro. Daniel Masterson
// Course: CS 176 -- Windows Desktop Development

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Class1
    {
        public static bool PasswordCheck(string userEntry)
        {
            // Quick check of length of entered password
            if (userEntry.Length < 8)
            {
                return false;
            }
            //All requirements that the string should have according with the rules of the password
            string validLettersSmall = "abcdefghijklmnopqrstuvwxyz";
            string validLettersCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string validSpecialChar = "`~!@#$%^&*()_-+={[}]:;\"\'<,>.?/|\\";
            string validDigits = "0123456789";
            int countSmall = 0;
            int countCaps = 0;
            int countChar = 0;
            int countDigits = 0;
            //testing the string to valid it and conting requirements
            for (int i = 0; i < userEntry.Length; i++)
            {
                //Finding small characters
                for (int j = 0; j < validLettersSmall.Length; j++)
                {
                    if (userEntry[i] == validLettersSmall[j])
                    {
                        countSmall++;
                    }
                }
                //Finding Cap letters
                for (int j = 0; j < validLettersCaps.Length; j++)
                {
                    if (userEntry[i] == validLettersCaps[j])
                    {
                        countCaps++;
                    }
                }
                //Finding  special Characters
                for (int j = 0; j < validSpecialChar.Length; j++)
                {
                    if (userEntry[i] == validSpecialChar[j])
                    {
                        countChar++;
                    }
                }
                //Finding digits
                for (int j = 0; j < validDigits.Length; j++)
                {
                    if (userEntry[i] == validDigits[j])
                    {
                        countDigits++;
                    }
                }
            }
            //Here see if the string is valid
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
