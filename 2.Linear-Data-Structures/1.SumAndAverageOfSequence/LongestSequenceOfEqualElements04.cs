using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that finds the longest subsequence of equal numbers in given List<int> 
//and returns the result as new List<int>. Write a program to test whether the method works correctly.

namespace LinearDataStructures
{
    public class LongestSequenceOfEqualElements04
    {
        public static string GetLongestSequence(List<int> ints)
        {
           Console.Clear();
           Console.WriteLine("Get Longest Sequence And Print");
           
           ints = GetMostCommonElementList(ints);
           return(PrintEqualElements(ints));
        }

        public static List<int> GetMostCommonElementList(List<int> intsList)
        {
            if (intsList.Count > 0)
            {
                intsList.Sort();
                int listCount = intsList.Count;
                int currentNumber = intsList[0];

                int occurance = 1;
                int maxOccurance = 1;
                for (int i = 0; i < listCount - 1; i++)
                {
                    if (intsList[i] == intsList[i+1])
                    {
                        occurance++;
                        if (occurance >= maxOccurance)
                        {
                            currentNumber = intsList[i];
                            maxOccurance = occurance;
                        }
                    }
                    else
                    {
                        occurance = 1;
                    }
                }

                List<int> numberList = new List<int>();
                for (int i = 0; i < maxOccurance; i++)
                {
                    numberList.Add(currentNumber);
                }
                    
                return numberList;
            }
            return new List<int>();
        }

        private static string PrintEqualElements(List<int> intsList)
        {
            if (intsList.Count > 0)
            {
                StringBuilder output = new StringBuilder();

                output.AppendFormat("The most times found number is: {0}", intsList[0]);
                output.Append("{ ");

                int intsCount = intsList.Count;
                for (int i = 0; i < intsCount; i++)
                {
                    output.Append(intsList[i].ToString() + " ");
                }

                output.AppendLine("}");
                return output.ToString();
            }
            return "No Numbers In The List";
        }
    }
}
