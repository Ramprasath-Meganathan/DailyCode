# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    #Brute force solution
    #O(n) time and O(1) space
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
       if not head:
            return head
       current = head
       count = 0
       while current:
            count+=1
            current = current.next
       dummy = ListNode()
       dummy.next = head
       current = dummy
       for _ in range(count-n):
            current = current.next
       current.next = current.next.next
       return dummy.next
     
     #two pointer solution one pass solution
     #O(n) time and O(1) space
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        dummy = ListNode()
        dummy.next = head
        fast = dummy
        slow = dummy
        for _ in range(n):
            fast = fast.next
        while fast.next:
            fast = fast.next
            slow = slow.next
        slow.next = slow.next.next
        return dummy.next
        

# Given the head of a linked list, remove the nth node from the end of the list and return its head.
 
# Example 1:

# Input: head = [1,2,3,4,5], n = 2
# Output: [1,2,3,5]
# Example 2:

# Input: head = [1], n = 1
# Output: []
# Example 3:

# Input: head = [1,2], n = 1
# Output: [1]
 