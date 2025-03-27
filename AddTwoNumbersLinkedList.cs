
// Definition for singly-linked list.
 public class ListNode {
     public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }
 
// O(m+n) time and O(n) space
public class AddTwoNumbersLinkedList {
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode sentinel = new ListNode(0);
        ListNode l1Current = l1;
        ListNode l2Current = l2;
        ListNode current = sentinel;
        int carry = 0;
        while(l1Current != null || l2Current != null)
        {
            int value1 = (l1Current != null) ? l1Current.val : 0;
            int value2 = (l2Current != null) ? l2Current.val : 0;
            int sum = carry + value1 + value2;
            carry = sum/10;
            current.next = new ListNode(sum%10);
            current = current.next;
            if(l1Current != null) 
                l1Current = l1Current.next;
            if(l2Current != null)
                l2Current = l2Current.next; 
        }

        if(carry > 0)
            current.next = new ListNode(carry);
        return sentinel.next;
    }
}

// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Example 1:

// Input: l1 = [2,4,3], l2 = [5,6,4]
// Output: [7,0,8]
// Explanation: 342 + 465 = 807.
// Example 2:

// Input: l1 = [0], l2 = [0]
// Output: [0]
// Example 3:

// Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
// Output: [8,9,9,9,0,0,0,1]
 

// Constraints:

// The number of nodes in each linked list is in the range [1, 100].
// 0 <= Node.val <= 9
// It is guaranteed that the list represents a number that does not have leading zeros.