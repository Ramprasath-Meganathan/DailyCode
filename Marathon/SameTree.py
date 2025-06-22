class Solution:
    #O(n) time and O(n) space Best case(balanced tree): O(logn) time and O(n) space
    # worst case(degenerate tree): O(n) time and O(n) space
    # where n is the number of nodes and h is the height of the tree
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        if not p and not q:
            return True
        if p and q and p.val == q.val:
           return (self.isSameTree(p.left,q.left) and 
            self.isSameTree(p.right,q.right))
        else:
            return False