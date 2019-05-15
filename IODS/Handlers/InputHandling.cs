using System;
using System.Collections.Generic;

namespace IODS.Handlers
{
    public class InputHandling
    {
        public static bool QuestionOptions(bool exit = true)
        {
            ConsoleKeyInfo menuOption = Console.ReadKey(true);

            if (menuOption.Key.Equals(ConsoleKey.Y))
            {
                return true;
            }

            else if (menuOption.Key.Equals(ConsoleKey.N))
            {
                if (exit)
                {
                    ProgramFlowHandling.Exit("Program will now exit. Press any key...");
                }
                return false;
            }

            else
            {
                return QuestionOptions();
            }
        }

        public static int ReadCollectionLength(string messagePrefix = "Collection Length: ")
        {
            try
            {
                OutputHandling.Question(messagePrefix, false);
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                if (arrayLength < 0)
                {
                    OutputHandling.Error("Invalid input value! Array Length must be a positive integer!!!");
                    return ReadCollectionLength(messagePrefix);
                }

                return arrayLength;
            }

            catch
            {
                OutputHandling.Error("Invalid input value! Please use an integer");
                return ReadCollectionLength(messagePrefix);
            }
        }

        public static void ReadCollectionElements(ref int[] array, int arrLen, ref int index)
        {
            for (int i = index; i < arrLen; i++)
            {
                try
                {
                    OutputHandling.Question(i, "-", "Element");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    OutputHandling.Error("Invalid input value! Please use an integer");
                    index = i--;
                }
            }
        }

        public static void ReadCollectionElements(ref SinglyLinkedList singlyLinkedList, int singlyLinkedListLength, ref int index)
        {

            for (int i = 0; i < singlyLinkedListLength; i++)
            {
                try
                {
                    OutputHandling.Question("Element " + i + ": ", false);
                    singlyLinkedList.AddLast(singlyLinkedList, ReadValue(""));
                }

                catch
                {
                    OutputHandling.Error("Invalid input value! Please use an integer");
                    index = i--;
                }
            }
        }

        public static void ReadCollectionElements(ref LinkedList<int> linkedList, int linkedListLength, ref int index)
        {

            for (int i = 0; i < linkedListLength; i++)
            {
                try
                {
                    OutputHandling.Question("Element " + i + ": ", false);
                    linkedList.AddLast(Convert.ToInt32(Console.ReadLine()));
                }

                catch
                {
                    OutputHandling.Error("Invalid input value! Please use an integer");
                    index = i--;
                }
            }
        }

        public static int ReadCollectionIndex(int arrLen, string message = "Collection index: ")
        {
            try
            {
                OutputHandling.Question(message, false);
                int index = Convert.ToInt32(Console.ReadLine());
                if (index > arrLen - 1 || index < 0)
                {
                    OutputHandling.Error("Invalid input value for index: MUST BE GREATER THAN OR EQUAL TO 0 AND LESSER THAN THE COLLECTION LENGTH");
                    return ReadCollectionIndex(arrLen, message);
                }

                return index;
            }

            catch
            {
                OutputHandling.Error("Invalid input value for index: MUST BE AN INTEGER");
                return ReadCollectionIndex(arrLen, message);
            }
        }

        public static int ReadValue(string message, string errorMessage = "Invalid input")
        {
            try
            {
                OutputHandling.Question(message, false);
                int x = Convert.ToInt32(Console.ReadLine());
                return x;
            }

            catch
            {
                OutputHandling.Error("Invalid input value! Must be an integer!");
                return ReadValue(message, errorMessage);
            }
        }

        public static string ReadString(string message = "", string errorMessage = "", bool mandatory = true)
        {
            OutputHandling.Message(message, newLine: false);
            string inputString = Console.ReadLine();

            return inputString;
        }

        public static decimal ReadValueD(string message)
        {
            try
            {
                OutputHandling.Question(message, false);
                decimal x = Convert.ToDecimal(Console.ReadLine());
                return x;
            }

            catch
            {
                OutputHandling.Error("Invalid input value! Must be an integer!");
                return ReadValueD(message);
            }
        }
    }
}
