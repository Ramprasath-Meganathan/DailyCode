/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class RemoveNthFromEndProgram {
    // Time complexity: O(n)
    // Space complexity: O(1)
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        int length = 0;
        while(current!=null)
        {
            length++;
            current = current.next;
        }
        int positionToRemove = length - n;
        if(positionToRemove==0)
            return head.next;
        current = head;
        for(int i = 0; i<positionToRemove-1;i++)
        {
            current = current.next;
        }
        current.next = current.next.next;
        return head;
    }

    // Time complexity: O(n)  - one pass
    // Space complexity: O(1)
    public ListNode RemoveNthFromEndTwoPointer(ListNode head, int n) {
       ListNode dummy = new ListNode(0);
       dummy.next = head;
       ListNode fast = dummy, slow=dummy;
       for(int i = 0; i <=n;i++)
            fast = fast.next;
        while(fast!=null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}