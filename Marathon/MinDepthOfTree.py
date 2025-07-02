# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    #O(n) time and O(n) space
    # Using Depth First Search (DFS) to find the minimum depth of a binary tree using
    def minDepth(self, root: Optional[TreeNode]) -> int:
        def dfs(node,depth):
            if not node:
                return float('inf')  # so it doesn't affect min()
            if not node.left and not node.right:
                return depth
            return min(dfs(node.left,depth+1),  dfs(node.right,depth+1))
        if not root:
            return 0
        return dfs(root,1)

     # O(n) time and O(n) space
    # Using recursion to find the minimum depth of a binary tree
    def minDepth(self, root: Optional[TreeNode]) -> int:
        if not root:
            return 0
        if not root.left:
            return 1+self.minDepth(root.right)
        if not root.right:
            return 1+self.minDepth(root.left)
        return 1+min(self.minDepth(root.left),self.minDepth(root.right))
    
#
# 111. Minimum Depth of Binary Tree
# Solved
# Easy
# Topics
# premium lock icon
# Companies
# Given a binary tree, find its minimum depth.

# The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

# Note: A leaf is a node with no children.

 

# Example 1:


# Input: root = [3,9,20,null,null,15,7]
# Output: 2
# Example 2:

# Input: root = [2,null,3,null,4,null,5,null,6]
# Output: 5
 

# Constraints:

# The number of nodes in the tree is in the range [0, 105].
# -1000 <= Node.val <= 1000
