using System;
using System.Linq;

namespace ImplementedLinkedList
{
    public class ListMain
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddLast(100);
            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddLast(50);

            linkedList.Remove(1);
            linkedList.Remove(4);

            ListItem<int> next = linkedList.FirstElement;
            while (next != null)
            {
                Console.WriteLine(next.Value);
                next = next.NextItem;
            }

            Console.WriteLine(linkedList.Count);
        }
    }
}

