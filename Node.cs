public class Node
{
    public Node(int d)
    {
        data = d;
    }

    private Node next = null;

    public int data;

    public Node Next { get => next; set => next = value; }
}