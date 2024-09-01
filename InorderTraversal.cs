/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class InorderTraversalRecursive {
    public IList<int> InorderTraversalMethod(TreeNode root) {
        List<int> values = new List<int>();
        return InorderTraversalMethod(root, values);
    }

    public IList<int> InorderTraversalMethod(TreeNode root, List<int> values)
    {
        if(root==null)
            return values;
        InorderTraversalMethod(root.left,values);
        values.Add(root.val);
        InorderTraversalMethod(root.right,values);
      return values;
    }
}


// Given the root of a binary tree, return the inorder traversal of its nodes' values.

 

// Example 1:

// Input: root = [1,null,2,3]

// Output: [1,3,2]

// Explanation:



// Example 2:

// Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]

// Output: [4,2,6,5,7,1,3,9,8]

// Explanation:



// Example 3:

// Input: root = []

// Output: []

// Example 4:

// Input: root = [1]

// Output: [1]

 

// Constraints:

// The number of nodes in the tree is in the range [0, 100].
// -100 <= Node.val <= 100