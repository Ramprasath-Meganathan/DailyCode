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
 // O(n+m) time and O(1) space
public class MergeTwoListsProgram {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode l3 = dummy;
        while(l1!=null&&l2!=null)
        {
            if(l1.val<l2.val)
            {
                l3.next =l1;
                l1 = l1.next;
            }
            else
            {
                l3.next = l2;
                l2 = l2.next;
            }
            l3 = l3.next;
        }
        if(l1!=null)
            l3.next = l1;
        else if(l2!=null)
            l3.next = l2;
        return dummy.next;
    }
}