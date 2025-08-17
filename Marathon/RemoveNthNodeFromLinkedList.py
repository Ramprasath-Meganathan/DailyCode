# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    #O(n) time and O(1) space
    #Iterative approach
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        count = 0
        dummy = ListNode()
        dummy.next = head
        current = dummy
        while current:
            current = current.next
            count+=1
        node_to_stop = count-n-1
        current = dummy
        for _ in range(node_to_stop):
            current = current.next
        current.next = current.next.next
        return dummy.next
    
    #two pass approach
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
       dummy = ListNode()
       dummy.next = head
       fast = dummy
       slow = dummy
       for _ in range(n+1):
          fast = fast.next
       while fast:
            slow = slow.next
            fast = fast.next
       slow.next = slow.next.next
       return dummy.next  
