# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    #O(n)time and O(n) space
    #This is a simple inorder traversal to get the kth smallest element in a BST
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
       arr = []
       def dfs(node):
            if not node:
                return 
            dfs(node.left)
            arr.append(node.val)
            dfs(node.right)
       dfs(root)
       return arr[k-1]
    

    # Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
#O(n) time and O(logn) space
#This is a recursive approach to find the kth smallest element in a BST
class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        count = 0
        def helper(root,k):
            nonlocal count
            if not root:
                return None
            left = helper(root.left,k)
            if left:
                return left
            count+=1
            if count == k:
                return root
            return helper(root.right,k)
        return helper(root,k).val


