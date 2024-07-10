public class MajorityElement {

    // O(n)
    public int MajorityElementMethod(int[] nums) {
        Dictionary<int,int> counter = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(counter.ContainsKey(nums[i]))
                counter[nums[i]] +=1;
            else
                counter[nums[i]] = 1;
        }
        return counter.MaxBy(x=>x.Value).Key;
    }
}

// Problem statement

// Given an array nums of size n, return the majority element.

// The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

// Example 1:

// Input: nums = [3,2,3]
// Output: 3
// Example 2:

// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
 

// Constraints:

// n == nums.length
// 1 <= n <= 5 * 104
// -109 <= nums[i] <= 109
 

// Follow-up: Could you solve the problem in linear time and in O(1) space?