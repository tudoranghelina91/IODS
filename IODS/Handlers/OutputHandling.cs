using System;
using System.Collections.Generic;
using IODS.DataStructures;

namespace IODS.Handlers
{
    public class OutputHandling
    {
        public static void Message(string message, ConsoleColor consoleColor = ConsoleColor.White, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(message);
            }

            else
            {
                Console.ForegroundColor = consoleColor;
                Console.Write(message);
            }

            Console.ResetColor();
        }

        public static void Question(string askMessage, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(askMessage);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(askMessage);
            }

            Console.ResetColor();
        }

        public static void Error(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
        }

        public static void Question(int arrayIndex, string separator, string indexDefinition = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0} {1} {2} ", indexDefinition, arrayIndex, separator);
            Console.ResetColor();
        }

        public static void ExitMessage(string exitMessage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(exitMessage);
            Console.ResetColor();
        }

        public static void PrintArrayLine(int[] arr, int arrLen, string resultMessage = "The array values are", string separator = "-")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultMessage);
            Console.ResetColor();
            for (int i = 0; i < arrLen; i++)
            {
                Console.WriteLine("[{0}] {1} {2}", i, separator, arr[i]);
            }
        }

        public static void PrintArrayLine(char[] arr, int arrLen, string resultMessage = "The array values are", string separator = "-")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultMessage);
            Console.ResetColor();
            for (int i = 0; i < arrLen; i++)
            {
                Console.WriteLine("[{0}] {1} {2}", i, separator, arr[i]);
            }
        }

        public static void PrintArray(int[] arr, int arrLen, string resultMessage, string separator = " ", string prefix = "", bool newLine = true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (newLine)
            {
                Console.WriteLine(resultMessage);
            }

            else
            {
                Console.Write(resultMessage + separator);
            }

            Console.ResetColor();
            if(prefix != "")
            {
                Console.Write(prefix);
            }
            for (int i = 0; i < arrLen; i++)
            {

                if (i < arrLen - 1)
                    Console.Write("{0}{1}", arr[i], separator);

                else
                    Console.Write("{0}", arr[i]);
            }

            Console.WriteLine();
        }

        public static void PrintArray(char[] arr, int arrLen, string resultMessage, string separator = " ", string prefix = "", bool newLine = true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (newLine)
            {
                Console.WriteLine(resultMessage);
            }

            else
            {
                Console.Write(resultMessage + separator);
            }

            Console.ResetColor();
            if (prefix != "")
            {
                Console.Write(prefix);
            }
            for (int i = 0; i < arrLen; i++)
            {

                if (i < arrLen - 1)
                    Console.Write("{0}{1}", arr[i], separator);

                else
                    Console.Write("{0}", arr[i]);
            }

            Console.WriteLine();
        }

        public static void PrintSinglyLinkedList(SinglyLinkedList singlyLinkedList, int singlyLinkedListLength)
        {
            SinglyLinkedListNode node = singlyLinkedList.head;

            // used for cycles
            int start = 0;

            while (node != null && start != singlyLinkedListLength)
            {
                Console.Write("{0} ", node.nodeData);
                node = node.next;
                start++;
            }

            Console.WriteLine();
        }

        public static void PrintLinkedList(LinkedList<int> linkedList)
        {
            LinkedListNode<int> linkedListNode = linkedList.First;

            while (linkedListNode != null)
            {
                Console.Write("{0} ", linkedListNode.Value);
                linkedListNode = linkedListNode.Next;
            }

            Console.WriteLine();
        }
    }
}
