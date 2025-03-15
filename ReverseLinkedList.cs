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
public class ReverseLinkedList {
    // Time complexity: O(n)
    // Space complexity: O(1)
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode previous = null;
        while(current!=null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
    }
}