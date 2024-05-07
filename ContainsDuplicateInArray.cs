public class Solution {
    //O(n) space and O(1) time
    public bool ContainsDuplicate1(int[] nums) {
        HashSet<int> numCounter = new HashSet<int>();
        foreach(var num in nums)
        {
            if(!numCounter.Contains(num))
                numCounter.Add(num);
            else
                return true;
        }
        return false;
    }
}

 public class ContainsDuplicate2 {
    public bool ContainsDuplicate(int[] nums) {
        return nums.Length != nums.Distinct(null).Count();
    }
}

// Problem statement
// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

// Example 1:

// Input: nums = [1,2,3,1]
// Output: true
// Example 2:

// Input: nums = [1,2,3,4]
// Output: false
// Example 3:

// Input: nums = [1,1,1,3,3,4,3,2,4,2]
// Output: true

// Constraints:
// 1 <= nums.length <= 105
// -109 <= nums[i] <= 109