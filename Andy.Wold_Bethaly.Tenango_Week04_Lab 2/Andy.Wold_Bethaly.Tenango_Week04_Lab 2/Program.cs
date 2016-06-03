
// Program: Lab #2 (Read/Write CSV files)
// Description: Calculate grades fom CSV files, write to new file.
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
using System.IO;

namespace Andy.Wold_Bethaly.Tenango_Week04_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input file name from user
            Write("Please enter the file name to retrieve: ");
            string inputFile = ReadLine();

            // Get output file name from user
            Write("Please enter the file name to save: ");
            string outputFile = ReadLine();

            // Pull data from input file
            var reader = new StreamReader(File.OpenRead(inputFile));
            List<string> listName = new List<string>();
            List<string> listAssign01 = new List<string>();
            List<string> listAssign02 = new List<string>();
            List<string> listAssign03 = new List<string>();
            List<string> listAssign04 = new List<string>();
            List<string> listAssign05 = new List<string>();
            List<string> listFirstName = new List<string>();
            List<string> listLastName = new List<string>();
            List<decimal> listAverageGrade = new List<decimal>();
            int spaceIndex = 0;
            char[] delimiterCharacters = { ' ', ',', '.', ':', '\t' };

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listName.Add(values[0]);
                listAssign01.Add(values[1]);
                listAssign02.Add(values[2]);
                listAssign03.Add(values[3]);
                listAssign04.Add(values[4]);
                listAssign05.Add(values[5]);
                listFirstName.Add("");
                listLastName.Add("");
                listAverageGrade.Add(0);
            }


            for (int i = 0; i < listName.Count; i++)
            {
                if (listName[i] != "")
                {
                    Write(i + ") ");
                    Write(listName[i] + " received ");
                    Write(listAssign01[i] + ", ");
                    Write(listAssign02[i] + ", ");
                    Write(listAssign03[i] + ", ");
                    Write(listAssign04[i] + ", and ");
                    Write(listAssign05[i] + ".  Their names are ");

                    // Parse out the first and last names from listName[]
                    spaceIndex = listName[i].IndexOf(" ");
// TEST             WriteLine(spaceIndex);
// TEST             listFirstName[i] = Convert.ToString(listName[i].Split(delimiterCharacters));
                    listFirstName[i] = listName[i].Substring(0,spaceIndex);
                    listLastName[i] = listName[i].Substring(spaceIndex + 1);

                    Write(listFirstName[i] + ", and ");
                    Write(listLastName[i] + ".");

                    listAverageGrade[i] = (Convert.ToDecimal(listAssign01[i]) + Convert.ToDecimal(listAssign02[i]) + Convert.ToDecimal(listAssign03[i]) + Convert.ToDecimal(listAssign04[i]) + Convert.ToDecimal(listAssign05[i])) / 5;
                    Write("Average: " + listAverageGrade[i] + ".");

                    WriteLine();
                }
            }

            // Calculate the average grade for each student (round to 1/100.)
            //done

            // Calculate the class average for each assignment (round to 1/100.)


            // Calculate an overall class average (round to 1/100.)


            // Export student names and averages to output file name.

            WriteLine("Please press Enter...");      // TEST
            ReadLine();                         // TEST
        }
    }
}
