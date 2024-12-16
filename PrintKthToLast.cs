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
}