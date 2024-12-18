public class LinkedListCRUD
{
    // O(n) time and O(1) space
    public Node AppendNodeToTail(Node linkedList, int d)
    {
        Node head = linkedList;
        while (head != null)
        {

            if (head.Next == null)
            {
                Node node = new Node(d);
                head.Next = node;
                return linkedList;
            }
            head = head.Next;
        }
        return linkedList;
    }

    public Node CreateLinkedList(int[] array)
    {
        Node head = null;
        Node current = null;
        foreach (var element in array)
        {
            Node node = new(element);
            if (head == null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }
            current = node;
        }
        return head;
    }

    public void PrintLinkedList(Node linkedList)
    {
        while (linkedList != null)
        {
            Console.Write(linkedList.data);
            linkedList = linkedList.Next;
        }
    }

    public Node DeleteLinkedListNode(Node list, int d)
    {
        Node previous = null;
        Node current = list;
        while (current.Next != null)
        {
            if (current.data != d)
            {
                previous = current;
            }
            else
            {
                previous.Next = current.Next;
                return list;
            }
            current = current.Next;
        }
        return list;
    }
}