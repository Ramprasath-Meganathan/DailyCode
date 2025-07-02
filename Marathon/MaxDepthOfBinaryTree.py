class Solution:
    def maxDepth(self, root: Optional[TreeNode]) -> int:
            # Depth First Search (DFS) to find the maximum depth of a binary tree using recursion
            #O(n) time and O(n) space
            def dfs(root,depth):
                if not root:
                    return depth
                left = dfs(root.left,depth+1)
                right = dfs(root.right,depth+1)
                return max(left,right)
            return dfs(root,0)

     #(O(n) time and O(n) space)
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        if not root:
            return 0
        return 1 + max(self.maxDepth(root.left),self.maxDepth(root.right))
    
    #   # Iterative approach using a stack
    # O(n) time and O(n) space
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        res = 0
        if not root:
            return 0
        stack = [[root,1]]
        while stack:
            node,depth = stack.pop()
            if node:
                res = max(res,depth)
                stack.append([node.left,depth+1])
                stack.append([node.right,depth+1])
        return res