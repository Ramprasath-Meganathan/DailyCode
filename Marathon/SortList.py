# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    #O(nlogn) time and O(n) space
    def sortList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        current = head
        el = []
        while current:
            el.append(current.val)
            current = current.next
        el.sort()
        head = ListNode()
        current = head
        for val in el:
            current.next = ListNode(val)
            current = current.next
        return head.next

    #O(nlogn) time and O(logn) space
    def sortList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if not head or not head.next:
            return head
        
        #split the halves
        left = head
        mid = self.get_mid(head)
        right =  mid.next
        mid.next = None

        #O(logn) levels time and O(logn) recursive stack space
        #sort left and right halves
        left = self.sortList(left) 
        right = self.sortList(right)
        return self.merge(left,right)

    #get mid 
    #O(n) time and O(1) space
    def get_mid(self,head):
        slow = head
        fast = head.next
        while fast and fast.next:
            fast = fast.next.next
            slow = slow.next
        return slow
    
    #merge the halves
    #O(n) per merge time and O(1) space
    def merge(self,left,right):
        dummy = ListNode()
        tail = dummy
        while left and right:
            if left.val < right.val:
                tail.next = left
                left = left.next
            else:
                tail.next = right
                right = right.next
            tail = tail.next
        tail.next = left if left else right
        return dummy.next

#148. Sort List

# Given the head of a linked list, return the list after sorting it in ascending order.

# Example 1:


# Input: head = [4,2,1,3]
# Output: [1,2,3,4]
# Example 2:


# Input: head = [-1,5,3,4,0]
# Output: [-1,0,3,4,5]
# Example 3:

# Input: head = []
# Output: []
 

# Constraints:

# The number of nodes in the list is in the range [0, 5 * 104].
# -105 <= Node.val <= 105
 

# Follow up: Can you sort the linked list in O(n logn) time and O(1) memory (i.e. constant space)?