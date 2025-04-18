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
 
 // O(n) time and O(logn) space
public class SortedArrayToBSTProgram {
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length == 0 || nums == null)
            return null;
        return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
    }

    public TreeNode SortedArrayToBSTHelper(int[] nums, int left, int right)
    {
        if(left>right)
            return null;
        
        int mid = left + (right-left)/2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBSTHelper(nums, left, mid -1);
        root.right = SortedArrayToBSTHelper(nums, mid+1, right);
        return root;
    }
}

// Given an integer array nums where the elements are sorted in ascending order, convert it to a 
// height-balanced
//  binary search tree.

// Example 1:

// Input: nums = [-10,-3,0,5,9]
// Output: [0,-3,9,-10,null,5]
// Explanation: [0,-10,5,null,-3,null,9] is also accepted:

// Example 2:


// Input: nums = [1,3]
// Output: [3,1]
// Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.
 
// Constraints:
// 1 <= nums.length <= 104
// -104 <= nums[i] <= 104
// nums is sorted in a strictly increasing order.