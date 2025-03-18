public class LinkedListCycle {
    // Time complexity: O(n)
    // Space complexity: O(n)
  public bool HasCycle(ListNode head) {
        var current = head;
        HashSet<ListNode> frequencyCounter = new HashSet<ListNode>();
        while(current!=null)
        {
            if(frequencyCounter.Contains(current))
                return true;
            frequencyCounter.Add(current);
            current = current.next;
        }
        return false;
    }

    // Time complexity: O(n)
    // Space complexity: O(1)
    public bool HasCyclePointer(ListNode head) {
      ListNode fast = head, slow = head;
      while(fast!=null && fast.next!=null)
      {
        slow = slow.next;
        fast = fast.next.next;
        if(fast==slow)
            return true;
      }
      return false;
    }
}