using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that removes from given sequence all negative numbers.

namespace LinearDataStructures
{
    public class RemoveNegativeValues05
    {
        public static void PrintWithNoNegatives(List<int> ints)
        {
            Console.Clear();
            Console.WriteLine("Print With No Negatives");

            ints = RemoveAllNegative(ints);
            Console.WriteLine(PrintList(ints));
        }

        private static List<int> RemoveAllNegative(List<int> intsList)
        {
            intsList.RemoveAll(x => x < 0);

            return intsList;
        }

        private static string PrintList(List<int> intsList)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("The list with removed negatives:");

            int intsCount = intsList.Count;
            for (int i = 0; i < intsCount; i++)
            {
                output.AppendLine(intsList[i].ToString());
            }
            return output.ToString();
        }
    }
}