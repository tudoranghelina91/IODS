namespace IODS
{
    public class SinglyLinkedList
    {
        SinglyLinkedListNode GetLastNode(SinglyLinkedList singlyLinkedList)
        {
            SinglyLinkedListNode temp = singlyLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void AddFirst(SinglyLinkedList singlyLinkedList, int new_data)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(new_data);
            new_node.next = singlyLinkedList.head;
            singlyLinkedList.head = new_node;
        }

        public void AddLast(SinglyLinkedList singlyLinkedList, int new_data)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(new_data);
            if (singlyLinkedList.head == null)
            {
                singlyLinkedList.head = new_node;
                return;
            }

            SinglyLinkedListNode lastNode = GetLastNode(singlyLinkedList);
            lastNode.next = new_node;
        }

        public void AddAfter(SinglyLinkedListNode prev_node, int data)
        {
            if (prev_node == null)
            {
                return;         // previous node cannot be null handling
            }

            SinglyLinkedListNode singlyLinkedListNode = new SinglyLinkedListNode(data);
            singlyLinkedListNode.next = prev_node.next;
            prev_node.next = singlyLinkedListNode;
        }

        public void Sort(SinglyLinkedList singlyLinkedList)
        {
            bool sorted = true;
            SinglyLinkedListNode singlyLinkedListNode = singlyLinkedList.head;

            do
            {
                while (singlyLinkedListNode != null)
                {
                    if (singlyLinkedListNode.nodeData > singlyLinkedListNode.next.nodeData)
                    {
                        sorted = false;

                        singlyLinkedListNode.nodeData += singlyLinkedListNode.next.nodeData;
                        singlyLinkedListNode.next.nodeData = singlyLinkedListNode.nodeData - singlyLinkedListNode.next.nodeData;
                        singlyLinkedListNode.nodeData -= singlyLinkedListNode.next.nodeData;
                    }

                    singlyLinkedListNode = singlyLinkedListNode.next;
                }
            } while (!sorted);
        }

        public SinglyLinkedListNode head;
    }
}
