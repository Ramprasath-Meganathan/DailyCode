class PrintKthToLast{

    // O(n) time and O(1) space
    public int PrintKthToLastRecursive(Node head,int k)
    {
        if(head==null)
            return 0;
        int index = PrintKthToLastRecursive(head.Next,k)+1;
        if(index==k)
            Console.Write(k+"th element to last node is "+ head.data);
        return index;
    }

    // O(n) time and O(1) space
    public Node PrintKthToLastTwoPointers(Node head, int k)
    {
        Node p1 = head, p2 = head;
        for(int i = 0;i < k; i++)
        {
            if(p1== null)
                return null;
            p1 = p1.Next;
        }
        while(p1 !=null)
        {
            p1 = p1.Next;
            p2 = p2.Next;
        }
        return p2;
    }
}