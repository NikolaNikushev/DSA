using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
//how many times each of them occurs.
//Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//2 --> 2 times
//3 --> 4 times
//4 --> 3 times

namespace LinearDataStructures
{
    public class FindOccuranceOfEachElement07
    {
        public static void PrintOccuranceOfEachElement(List<int> ints)
        {
            Console.Clear();
            Console.WriteLine("Print Occurance Of Each Element");
          
            int[,] array = new int[ints.Count - 1, 2];
            array = GetMostCommonElementList(ints);
            Console.WriteLine(PrintEqualElements(array));
        }

        private static int[,] GetMostCommonElementList(List<int> intsList)
        {
            intsList.Sort();
           
            int listCount = intsList.Count;
            int[,] elementsOccurances = new int[listCount, 2];

            int currentNumber = intsList[0];
           
            int occurance = 1;
            for (int j = 0; j < listCount; j++)
            {
                if (j == listCount - 1 && intsList[j] != intsList[j - 1])
                {
                    currentNumber = intsList[j];
                    elementsOccurances[j, 0] = currentNumber;
                    elementsOccurances[j, 1] = 1;
                }
                else if (j != listCount - 1 && intsList[j] == intsList[j + 1])
                {
                    occurance++;
                }
                else
                {
                    currentNumber = intsList[j];
                    elementsOccurances[j, 0] = currentNumber;
                    elementsOccurances[j, 1] = occurance;
                    occurance = 1;
                }
            }
          
            return elementsOccurances;
        }

        private static string PrintEqualElements(int[,] intsList)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < intsList.GetLength(0); i++)
            {
                if (intsList[i,1] > 0)
                {
                    output.AppendFormat("The number {0} --> {1} times", intsList[i, 0], intsList[i, 1]);
                    output.AppendLine(); 
                }
            }
            
            return output.ToString();
        }
    }
}
