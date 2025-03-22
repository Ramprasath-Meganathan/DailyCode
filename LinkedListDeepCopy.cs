/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

// Time complexity: O(n)
// Space complexity: O(n)
// Deep copy of a linked list with random pointer
public class LinkedListDeepCopy {
    public Node CopyRandomList(Node head) {
        Dictionary<Node,Node> oldToNew = new Dictionary<Node,Node>();
        if(head==null)
            return null;
        var current = head;
        while(current!=null)
        {
            var copy = new Node(current.val);
            oldToNew[current] = copy;
            current = current.next;
        }
        current = head;
        while(current!=null)
        {
            var copy = oldToNew[current];
            copy.next = current.next!=null ? oldToNew[current.next]: null;
            copy.random = current.random!=null ? oldToNew[current.random]:null;
            current = current.next;
        }
        return oldToNew[head];
    }
}