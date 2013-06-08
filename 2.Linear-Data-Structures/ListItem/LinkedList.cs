using System;
using System.Linq;

namespace ImplementedLinkedList
{
    public class LinkedList<T>
    {
        public ListItem<T> FirstElement { get; set; }
        public ListItem<T> LastElement { get; set; }

        private ListItem<T> currentElement;

        public int Count
        {
            get
            {
                return CheckCount();
            }
        }

        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
                this.LastElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> item = new ListItem<T>(value);

                item.NextItem = this.FirstElement;
                this.FirstElement = item;
            }            
        }

        public void AddLast(T value)
        {
            if (this.LastElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
                this.LastElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> item = new ListItem<T>(value);

                this.currentElement = this.FirstElement;
                while (this.currentElement.NextItem != null)
                {
                    this.currentElement = this.currentElement.NextItem;
                }

                this.currentElement.NextItem = item;
            }
        }

        public void Remove(T value)
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("You can't remove element from empty list");
            }

            this.currentElement = this.FirstElement;
            ListItem<T> listWithElementToRemove = this.currentElement;

            while (this.currentElement.NextItem != null)
            {
                if ((dynamic)this.currentElement.Value == (dynamic)value)
                {
                    listWithElementToRemove = this.currentElement.NextItem;


                    this.FirstElement.NextItem = listWithElementToRemove;
                    break;
                }


                this.FirstElement.NextItem = listWithElementToRemove.NextItem;
                this.currentElement = this.currentElement.NextItem;
            }
        }

        public void PrintList()
        {
            this.currentElement = this.FirstElement;

            Console.WriteLine(currentElement.Value);

            while (this.currentElement.NextItem != null)
            {
                this.currentElement = this.currentElement.NextItem;
                Console.WriteLine(this.currentElement.Value);
            }
        }

        private int CheckCount()
        {
            if (FirstElement == null)
            {
                return 0;
            }

            this.currentElement = this.FirstElement;

            int counter = 1;
            while (this.currentElement.NextItem != null)
            {
                counter++;
                this.currentElement = this.currentElement.NextItem;
            }

            return counter;
        }
    }
}
