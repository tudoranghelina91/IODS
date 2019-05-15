using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODS.DataStructures
{
    public class Queue
    {
        public void Enqueue(int value)
        {
            QueueItem newItem = new QueueItem(value);

            if (First == null)
            {
                First = newItem;
            }

            else
            {
                newItem.next = First;
                First = newItem;
            }
        }

        public void Dequeue()
        {
            if (First != null)
            {
                First = First.next;
            }
        }

        public void Print()
        {
            QueueItem traverse = First;
            while (traverse != null)
            {
                Console.Write($"{traverse.Value} ");
                traverse = traverse.next;
            }

            Console.WriteLine();
        }

        public QueueItem First = null;
    }
}
