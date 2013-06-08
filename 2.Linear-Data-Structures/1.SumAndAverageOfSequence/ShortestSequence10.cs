using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//* We are given numbers N and M and the following operations:
//N = N+1
//N = N+2
//N = N*2
//Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
//Example: N = 5, M = 16
//Sequence: 5 --> 7 --> 8 --> 16

namespace LinearDataStructures
{
    public class ShortestSequence10
    {
        public static void GetAndPrintShortestSequence()
        {
            Console.Clear();
            Console.WriteLine("Get Shortes Sequence");
            Console.WriteLine("Enter the starting N and ending M, each on a seperated row.\nN > M");

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            while (start > end && start >= 0)
            {
                Console.WriteLine("Enter the starting N and ending M, each on a seperated row.\nN > M");
                start = int.Parse(Console.ReadLine());
                end = int.Parse(Console.ReadLine());
            }

            Queue<int> steps = FromStartToEnd(start, end);

            Console.WriteLine(GetOutputs(steps));
        }

        //Calling recursion to calculate the drop down from the top  to the bottom so I know what is the next number that I will need.
        //They are like checkpoints
        private static Queue<int> RecursionGet(int start, int end, Queue<int> ints)
        {
            if (start >= end)
            {
                ints.Enqueue(end);
                return ints;
            }
            else
            {
                RecursionGet(start, end / 2, ints);
            }

            ints.Enqueue(end);        
            return ints;
        }

        //Following the formula moves the step from start closer to the end
        private static Queue<int> FromStartToEnd(int start, int end)
        {
            Queue<int> ints = new Queue<int>();
            Queue<int> returnedInts = new Queue<int>();

            returnedInts.Enqueue(start);
            ints = RecursionGet(start, end, ints);

            int currentNumber = start;
            int startingNumber = ints.Dequeue();

            if (startingNumber < currentNumber )
            {
                startingNumber = ints.Dequeue();
            }

            while (currentNumber != end)
            {
                //If true starts adding the numbers that are needed to get to the next "checkpoint" :D
                if (currentNumber == startingNumber)
                {
                    int nextNumber = ints.Dequeue();
                    if (currentNumber * 2 == nextNumber)
                    {
                        currentNumber *= 2;
                    }
                    else if (currentNumber + 2 == nextNumber)
                    {
                        currentNumber += 2;
                    }
                    else if (currentNumber * 2 + 1 == nextNumber && currentNumber != 0)
                    {
                        currentNumber *= 2;
                        returnedInts.Enqueue(currentNumber);
                        currentNumber += 1;
                    }
                    else if (ints.Peek() == currentNumber + 2) // checks for example 0 20 if the next checkpoint can be reached faster
                    {
                        currentNumber += 2;
                    }
                    else
                    {
                        currentNumber += 1;
                    }
                    startingNumber = currentNumber;
                }

                //With this else if I get the starting number as same as the current number, 
                //so I can start looping for the next example 4 20, 
                //the starting number is 5 (20 / 2 /2) so it adds 1 and goes to the checkpoint --> 5

                else if (currentNumber * 2 <= startingNumber && 
                    currentNumber * 2 <= end)
                {
                    currentNumber *= 2;
                }
                else if (currentNumber + 2 <= startingNumber && 
                    currentNumber + 2 <= end)
                {
                    currentNumber += 2;
                }
                else if (ints.Peek() == currentNumber + 2)
                {
                    currentNumber += 2;
                }
                else
                {
                    currentNumber += 1;
                }
                returnedInts.Enqueue(currentNumber);
            }
            return returnedInts;
        }

        private static string GetOutputs(Queue<int> stepNumbers)
        {
            StringBuilder output = new StringBuilder();
            foreach (int step in stepNumbers)
            {
                output.Append(step.ToString() + " --> ");
            }
            output.AppendLine("FINISHED");
            return output.ToString();
        }
    }
}
