using System;
using System.Linq;

namespace ImplementedStack
{
   public class StackMain
    {
       public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(5);

            int[] stackToArray = stack.ToArray();
            for (int i = 0; i < stackToArray.Length; i++)
            {
                Console.Write(stackToArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(0));
            stack.Clear();
            Console.WriteLine(stack.Count);
        }
    }
}

