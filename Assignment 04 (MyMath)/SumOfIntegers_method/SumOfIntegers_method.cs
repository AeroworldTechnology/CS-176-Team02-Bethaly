using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _method_SumOfIntegers
{
    class Program
    {
        public static int SumOfIntegers(int[] array)
        {
            int resultSum = 0;
            return resultSum; 
        }
        static void Main(string[] args)
        {
            int[] userArray = new int[] {};
            int userInput = 1;
            int countArray = 0;

            WriteLine("Please enter integers (Enter '0' when finished)");

            while (userInput != 0)
            {
                userInput = Convert.ToInt32(ReadLine());
                userArray[countArray] += userInput;
                countArray++;
            }

            WriteLine(userArray);
            WriteLine("Press any key...");
            ReadLine();

            int valuesSum = SumOfIntegers(userArray);

        }
    }
}
