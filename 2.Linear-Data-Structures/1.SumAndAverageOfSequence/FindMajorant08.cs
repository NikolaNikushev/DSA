using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//* The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. 
//Write a program to find the majorant of given array (if exists). Example:
//{2, 2, 3, 3, 2, 3, 4, 3, 3} --> 3

namespace LinearDataStructures
{
    public class FindMajorant08
    {
        public static void PrintTheMajorant(List<int> ints)
        {
            Console.Clear();
            Console.WriteLine("PrintTheMajorant");
          
            int majorant = 0;
            majorant = GetMajorant(ints);
            Console.WriteLine(PrintMajorant(majorant));
        }

        private static int GetMajorant(List<int> intsList)
        {
            intsList.Sort();

            int listCount = intsList.Count;

            int majorant = intsList[0];

            int occurance = 1;
            for (int i = 0; i < listCount; i++)
            {
                if (i == listCount - 1 && intsList[i] != intsList[i - 1])
                {
                    break;
                }
                else if (i != listCount - 1 && intsList[i] == intsList[i + 1])
                {
                    occurance++;
                }
                else
                {
                    if (occurance == listCount/2 + 1)
                    {
                        majorant = intsList[i];
                        break;
                    }
                    else
                    {
                        occurance = 1;
                    }
                }
            }

            return majorant;
        }

        private static string PrintMajorant(int majorant)
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("The majorant --> {0}", majorant);
            output.AppendLine();

            return output.ToString();
        }
    }
}
