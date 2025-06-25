# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
            #O(h) for recursive stack and O(n) time for visiting all nodes
            if not root:
                return []
            return ([root.val]+self.preorderTraversal(root.left)+
            self.preorderTraversal(root.right))
    
    #REcursive solution with a helper function
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
            res = []
            def preorder(root,res):
                if not root:
                    return []
                res.append(root.val)
                preorder(root.left,res)
                preorder(root.right,res)
            preorder(root,res)
            return res
    
    #Iterative solution - DFS using a stack
    #O(n) time and O(n) space where h is the height of the tree
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
            res = []
            stack = [root]
            while stack:
                node = stack.pop()
                if node:
                    res.append(node.val)
                    if node.right:
                        stack.append(node.right)
                    if node.left:
                        stack.append(node.left)
            return res


            
            

            
          