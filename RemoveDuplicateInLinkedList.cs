public class RemoveLinkedListDuplicates {
    public Node RemoveDuplicates(Node list)
    {
        Node previous = null;
        Node current = list;
        HashSet<int> visited = new HashSet<int>();
        while (current.Next != null)
        {
           if(!visited.Contains(current.data))
            {
                visited.Add(current.data);
            }
            else
            {
                previous.Next = current.Next;
            }
            previous = current;
            current = current.Next;
        }
        return list;
    }
}