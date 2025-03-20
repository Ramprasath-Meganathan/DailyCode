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
public class ReOrderListProgram {
    public void ReorderList(ListNode head) {
        ListNode slow = head, fast = head.next;
        //find middle point
        while(fast!=null&&fast.next!=null)
        {
            slow=slow.next;
            fast = fast.next.next;
        }

        ListNode secondHalf = slow.next;
        slow.next = null;
        ListNode previous = null;
        while (secondHalf!=null)
        {
            var temp = secondHalf.next;
            secondHalf.next = previous;
            previous = secondHalf;
            secondHalf = temp;
        }
        var firstHalf = head;
        secondHalf = previous;
        while(secondHalf!=null)
        {
            var temp1 = firstHalf.next;
            var temp2 = secondHalf.next;
             firstHalf.next = secondHalf;
            secondHalf.next = temp1;

            // Move to the next pair
            firstHalf = temp1;
            secondHalf = temp2;
        }
    }
}