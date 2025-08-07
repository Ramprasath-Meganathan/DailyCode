# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        #O(n) time and O(n) space
        pals = []
        while head:
            pals.append(head.val)
            head = head.next
        return pals == pals[::-1]

    #O(n) time and O(1) space
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        fast = slow = head

        #find middle node
        while fast and fast.next:
            fast = fast.next.next
            slow = slow.next
        
        #reverse second half
        prev = None
        while slow:
            next_node = slow.next
            slow.next = prev
            prev = slow
            slow = next_node
        
        # compare both halves
        left,right = head,prev
        while right:
            if left.val!=right.val:
                return False
            left = left.next
            right = right.next

        return True
        
# 234. Palindrome Linked List
# Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

# Example 1:

# Input: head = [1,2,2,1]
# Output: true
# Example 2:

# Input: head = [1,2]
# Output: false
 
# Constraints:

# The number of nodes in the list is in the range [1, 105].
# 0 <= Node.val <= 9
 
# Follow up: Could you do it in O(n) time and O(1) space?