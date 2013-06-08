using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class AccessFor1_10
    {
        public static void Main()
        {
            bool continueProgram = true;
            while (continueProgram) //Loops the program until end is entered
            {
                Console.WriteLine(ProgramsInformation());
                List<int> intsList = new List<int>();
                string input = string.Empty;
                try
                {
                   
                    input = Console.ReadLine().ToLower();

                    if (input != "end" && int.Parse(input) <= 8 &&
                        int.Parse(input) >= 1 && int.Parse(input) != 2)
                    {
                        Console.WriteLine("Enter the numbers for the list," +
                            "seperated by a new row.\nEnd with an empty row.");
                        int numbersCount = 0;
                        while (true)
                        {
                            try
                            {
                                numbersCount++;
                                Console.Write("Number{0} = ", numbersCount);
                                string number = Console.ReadLine();
                                if (number == "" || number == null)
                                {
                                    break;
                                }
                                else
                                {
                                    intsList.Add(GetNumber(number));
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The entered string was not a number, try again");
                            }

                        }
                    }
                    switch (input)
                    {
                        case "1":
                            SumAndAverage01.PrintAverageAndSumOfInts(intsList);
                            break;
                        case "2":
                            ReverseStack02.FillStackAndPrintReversed();
                            break;
                        case "3":
                            SortListInIncreasingOrder03.PrintIncreasingList(intsList);
                            break;
                        case "4":
                            Console.WriteLine(
                                LongestSequenceOfEqualElements04.GetLongestSequence(intsList));
                            break;
                        case "5":
                            RemoveNegativeValues05.PrintWithNoNegatives(intsList);
                            break;
                        case "6":
                            RemoveOddOccurances06.PrintWithRemovedOddOccurances(intsList);
                            break;
                        case "7":
                            FindOccuranceOfEachElement07.PrintOccuranceOfEachElement(intsList);
                            break;
                        case "8":
                            FindMajorant08.PrintTheMajorant(intsList);
                            break;
                        case "9":
                            Console.Clear();
                            Console.WriteLine("Get S Sum");
                            Console.WriteLine("Enter the starting N number for the S sum.");

                            int numberN = int.Parse(Console.ReadLine());
                            SSum09.GetSSum(numberN);
                            break;
                        case "10":
                            ShortestSequence10.GetAndPrintShortestSequence();
                            break;
                        case "end":
                            continueProgram = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("The input must be from 1 to 10 inclusive!");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("The enterd string was not valid! Try again!");
                }
            }
        }

        private static int GetNumber(string text)
        {
            int number = 0;
            number = int.Parse(text);
            return number;
        }

        private static StringBuilder ProgramsInformation()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine();
            info.AppendLine("What program do you wish to test?");
            info.AppendLine("".PadLeft(40, '-'));
            info.AppendLine("1 for SumAndAverage");
            info.AppendLine("2 for ReverseStack");
            info.AppendLine("3 for SortListInIncreasingOrder");
            info.AppendLine("4 for LongestSequenceOfEqualElements");
            info.AppendLine("5 for RemoveNegativeValues");
            info.AppendLine("6 for RemoveOddOccurances");
            info.AppendLine("7 for FindOccuranceOfEachElement");
            info.AppendLine("8 for FindMajorant");
            info.AppendLine("9 for SSum");
            info.AppendLine("10 for ShortestSequence");
            info.AppendLine("end to stop");
            info.AppendLine("".PadLeft(40, '-'));

            return info;
        }
    }
}
