public class ProductOfArrayExceptSelf {

    // O(n) time and O(n) space
    public int[] ProductExceptSelf(int[] nums) {
        int[] productArray = new int[nums.Length];
        productArray[0]  = 1;
        for(int i = 1 ; i < nums.Length; i++ )
        {
            productArray[i] = productArray[i-1]* nums[i-1];
        }
        int product = 1;
        for( int i = nums.Length-1; i >=0; i--)
        {
            productArray[i] = productArray[i] * product;
            product *= nums[i];
        }
        return productArray;
    }

    // O(n^2) time and O(n) space
     public int[] ProductExceptSelfOptimized(int[] nums) {
       int[] productArray = new int[nums.Length];
       int product = 1;
       for(int i = 0; i < nums.Length; i++)
        {
          for(int j= 0; j<nums.Length; j++)
            {
            if(i==j)
                continue;
            product*= nums[j];
            }
            productArray[i] = product;
            product = 1;
        }
        return productArray;
    }
}

// 238. Product of Array Except Self
// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

// You must write an algorithm that runs in O(n) time and without using the division operation.

// Example 1:

// Input: nums = [1,2,3,4]
// Output: [24,12,8,6]
// Example 2:

// Input: nums = [-1,1,0,-3,3]
// Output: [0,0,9,0,0]
 

// Constraints:

// 2 <= nums.length <= 105
// -30 <= nums[i] <= 30
// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

// Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)