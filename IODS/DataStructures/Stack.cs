using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IODS.Handlers;

namespace IODS.DataStructures
{
    public class Stack
    {
        public void Push(int value)
        {
            StackItem newStackItem = new StackItem();
            newStackItem.Value = value;
            newStackItem.next = Top;
            Top = newStackItem;
        }

        public void Pop()
        {
            Top = Top.next;
        }

        public void Print()
        {
            StackItem currentStackItem = Top;

            while (currentStackItem != null)
            {
                Console.Write($"{currentStackItem.Value} ");
                currentStackItem = currentStackItem.next;
            }

            Console.WriteLine();
        }

        public StackItem Top = null;
    }
}
