# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
# Recursive solution 1
#O(n) time and O(1) space
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        res = []
        def dfs(root):
            if not root:
                return None
            if root.left:
                dfs(root.left)
            res.append(root.val)
            if root.right:
                dfs(root.right)
        dfs(root)
        return res

#Recursive solution 2 
#O(n) time and O(1) space
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        return (self.inorderTraversal(root.left)+[root.val]+
        self.inorderTraversal(root.right))



        