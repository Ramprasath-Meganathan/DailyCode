class Solution:
    #O(n) time and O(1) space
    # Using a single pointer to traverse the linked list and remove duplicates
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
      if not head:
        return None
      current = head
      while current and current.next:
            if current.val == current.next.val:
                current.next = current.next.next
            else:
                current = current.next
      return head