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

//yet to finish
public class AddTwoNumbersLinkedList {
    ListNode resultNode = new ListNode();
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1!=null&&l2!=null)
        {
            resultNode.val = l1.val+l2.val;
            var result
            if(resultNode.val/10>0)
                
            if(l1.next!=null&&l2.next!=null)
                resultNode.next = AddTwoNumbers(l1.next,l2.next);
            else
            {
                resultNode.next = null;
                return resultNode;
            }
        }
        return resultNode;
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