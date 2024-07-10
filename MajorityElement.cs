public class MajorityElement {

    // O(n) time and space
    public int MajorityElementSolution1(int[] nums) {
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

    // O(n) time and O(1) space
    public int MajorityElementSolution2(int[] nums) {
      int majority = nums[0];
      int counter = 1, i = 1;
      int length = nums.Length;
      for(i = 1; i < length; i++)
      {
        if(nums[i]==majority)
            counter++;
        else
            counter--;
        if(counter==0)
        {
            majority = nums[i];
            counter = 1;
        }
      }
      return majority;
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