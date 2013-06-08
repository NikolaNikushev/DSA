using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that finds the longest subsequence of equal numbers in given List<int> 
//and returns the result as new List<int>. Write a program to test whether the method works correctly.

namespace LinearDataStructures
{
    public class RemoveOddOccurances06
    {
        public static void PrintWithRemovedOddOccurances(List<int> ints)
        {
            Console.Clear();
            Console.WriteLine("Get Removed Odd Occurances");

            ints = GetMostCommonElementList(ints);
            Console.WriteLine(PrintEqualElements(ints));
        }

        private static List<int> GetMostCommonElementList(List<int> intsList)
        {
            intsList.Sort();
            List<int> listWithRemovedElements =new List<int>(intsList);
            int listCount = intsList.Count;
            int currentNumber = intsList[0];

            int occurance = 1;
            for (int i = 0; i <= listCount - 1; i++)
            {
                if (i == listCount - 1 && intsList[i] != intsList[i-1])
                {
                    currentNumber = intsList[i];
                    listWithRemovedElements.RemoveAll(x => x == currentNumber);
                }
                else if (intsList[i] == intsList[i + 1])
                {
                    occurance++;
                }
                else
                {
                    if (occurance % 2 != 0)
                    {
                        currentNumber = intsList[i];
                        listWithRemovedElements.RemoveAll(x => x == currentNumber);
                    }
                    occurance = 1;
                }
            }
           
            return listWithRemovedElements;
        }

        private static string PrintEqualElements(List<int> intsList)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("The list with removed odd occuring elements:");
            output.Append("{ ");

            int intsCount = intsList.Count;
            for (int i = 0; i < intsCount; i++)
            {
                output.Append(intsList[i].ToString() + " ");
            }

            output.AppendLine("}");
            return output.ToString();
        }
    }
}
