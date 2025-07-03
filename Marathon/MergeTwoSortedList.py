# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    #Overall time and space complexity O(m+n) time and O(m+n) space
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
      dummy = ListNode()
      list3 = dummy
      while list1 and list2:
        if list1.val < list2.val:
            list3.next = ListNode(list1.val)
            list1 = list1.next
        else:
            list3.next = ListNode(list2.val)
            list2 = list2.next
        list3 = list3.next
      if list1:
            list3.next = list1
      elif list2:
            list3.next = list2
      return dummy.next