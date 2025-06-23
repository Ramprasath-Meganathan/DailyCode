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
        
    # Iterative DFS solution:
    # O(n) time and O(n) space 
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        stack = [(p,q)]
        while stack:
            node1,node2 = stack.pop()
            if not node1 and not node2:
                continue
            if not node1 or not node2 or node1.val!=node2.val:
                return False
            stack.append((node1.left,node2.left))
            stack.append((node1.right,node2.right))
        return True

     #BFS: #O(n) time and O(n) space Best case(balanced tree): O(logn) time and O(n) space
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        q1 = collections.deque([p])
        q2 = collections.deque([q])
        while q1 and q2:
            node1 = q1.popleft()
            node2 = q2.popleft()
            if not node1 and not node2:
                continue
            if not node1 or not node2 or node1.val!=node2.val:
                return False
            q1.append(node1.left)
            q1.append(node1.right)
            q2.append(node2.left)
            q2.append(node2.right)
        return True
            
# LeetCode 100. Same Tree
# https://leetcode.com/problems/same-tree/Given the roots of two binary trees p and q, write a function to check if they are the same or not.

# Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

 

# Example 1:


# Input: p = [1,2,3], q = [1,2,3]
# Output: true
# Example 2:


# Input: p = [1,2], q = [1,null,2]
# Output: false
# Example 3:


# Input: p = [1,2,1], q = [1,1,2]
# Output: false
 

# Constraints:

# The number of nodes in both trees is in the range [0, 100].
# -104 <= Node.val <= 104