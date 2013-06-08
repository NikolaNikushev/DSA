using System;
using System.Linq;

namespace ImplementedLinkedList
{
    public class ListItem<T>
    {
        public T Value { get; set; }
        public ListItem<T> NextItem { get; set; }

        public ListItem(T data)
        {
            this.Value = data;
        }
    }
}
