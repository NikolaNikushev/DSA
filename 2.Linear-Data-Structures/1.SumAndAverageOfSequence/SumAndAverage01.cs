using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads from the console a sequence of positive integer numbers. 
//The sequence ends when empty line is entered. Calculate and print the sum and average
//of the elements of the sequence. Keep the sequence in List<int>.

namespace LinearDataStructures
{
   public class SumAndAverage01
    {
        public static void PrintAverageAndSumOfInts(List<int> ints)
        {
            Console.Clear();
            Console.WriteLine("Get Average And Sum Of Items");

            Console.WriteLine("The average is:" + CalculateAverage(ints));
            Console.WriteLine("The sum is:" + CalculateSum(ints));
        }

        private static double CalculateAverage(List<int> numberList)
        {
            double average = 0;
            average = numberList.Average();
            return average;
        }

        private static double CalculateSum(List<int> numberList)
        {
            long sum = 0;
            sum = numberList.Sum();
            return sum;
        }
    }
}
