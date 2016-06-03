using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int bob = 55; int sam = 66;

            WriteLine("bob is now " + bob + ", and sam is now " + sam + ".");

            swap(ref bob, ref sam);

            WriteLine("bob is now " + bob + ", and sam is now " + sam + ".");
        }

        public static void swap(ref int a, ref int b)
        {
            int holder;      // create new object

            holder = a;     // swaps values between the objects
            a = b;
            b = holder;
        }

        public static void doNothing()
        {

        }
    }
}
