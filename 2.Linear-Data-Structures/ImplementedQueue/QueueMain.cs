using System;
using System.Linq;

namespace ImplementedQueue
{
    public class QueueMain
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(15);
            queue.Enqueue(25);
            queue.Enqueue(35);

            int[] array = queue.ToArray();
            Console.WriteLine(queue.Peek());
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine(queue.Contains(15));
        }
    }
}
