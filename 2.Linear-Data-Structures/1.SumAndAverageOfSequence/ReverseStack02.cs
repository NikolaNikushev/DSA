using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads N integers from the console and reverses them using a stack. 
//Use the Stack<int> class.

namespace LinearDataStructures
{
    public class ReverseStack02
    {
        public static void FillStackAndPrintReversed()
        {
            Console.Clear();
            Console.WriteLine("Print Reversed Stack");

            Console.Write("Enter the stack number count: ");
            int numbersCount = int.Parse(Console.ReadLine());

            Stack<int> ints = new Stack<int>();
            int input = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                input = GetNumber(Console.ReadLine());
                ints.Push(input);
            }

            Console.WriteLine("The stack reversed:");
            for (int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine(ints.Pop());
            }
        }

        private static int GetNumber(string text)
        {
            int number = 0;
            number = int.Parse(text);
            return number;
        }
    }
}
