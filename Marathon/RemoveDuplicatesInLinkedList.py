def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        #O(n) time and O(1) space
        if not head:
            return None
        current = head
        while current.next:
            if current.val == current.next.val:
                current.next = current.next.next
            else:
                current = current.next
        return head