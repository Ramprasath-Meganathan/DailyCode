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

 // O(n) time and O(h) space - h is the height of the binary tree
public class BalancedBinaryTree {
    public bool IsBalanced(TreeNode root) {
        return IsChecked(root)!=-1;
    }

    private int IsChecked(TreeNode node)
    {
        if(node==null)
            return 0;
        int left = IsChecked(node.left);
        if(left==-1)
            return -1;
        int right = IsChecked(node.right);
        if(right==-1)
            return -1;
        if(Math.Abs(left-right)>1)
            return -1;
        return 1+Math.Max(left,right);
    }
}

// Input: root = [1,2,2,3,3,null,null,4,4]
// Output: false
// Example 3:

// Input: root = []
// Output: true
 

// Constraints:

// The number of nodes in the tree is in the range [0, 5000].
// -104 <= Node.val <= 104