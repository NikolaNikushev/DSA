using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a sequence of integers (List<int>) ending with an empty line
//and sorts them in an increasing order.

namespace LinearDataStructures
{
   public class SortListInIncreasingOrder03
    {
        public static void PrintIncreasingList(List<int> ints)
        {
            Console.Clear();
            Console.WriteLine("Print Increasing List");

            SortInIncreasing(ints);
            Console.WriteLine(PrintList(ints));
        }

        private static List<int> SortInIncreasing(List<int> numberList)
        {
            numberList.Sort();
            return numberList;
        }

        private static string PrintList(List<int> intsList)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("The List in increasing order is:");

            int intsCount = intsList.Count;
            for (int i = 0; i < intsCount; i++)
            {
                output.AppendLine(intsList[i].ToString());
            }
            return output.ToString();
        }
    }
}
