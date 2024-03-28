namespace DailyCode;    
    static class TwoSumProb
    {
    public static int[] TwoSum(int[] nums, int target)
    {
        for(int i=0; i< nums.Length -1 ; i++)
        {
        for(int j=i+1; j<nums.Length;j++)
        {
           if(nums[i]+nums[j] == target)
                return [i,j];
            continue;
        }
        }
        return [];
    }


  public static int[] TwoNumberSum(int[] array, int targetSum) {
    Array.Sort(array);
    int minPointer = 0;
    int maxPointer = array.Length-1;
    while(minPointer<maxPointer)
        {
        var computedValue = array[minPointer]+array[maxPointer];
        if(computedValue == targetSum)
            return new int[2]{array[minPointer],array[maxPointer]};
        else if(computedValue<targetSum)
            minPointer++;
        else
            maxPointer --;
        continue;
        }
    return new int[0];
  }

    }


//        Console.WriteLine("[{0}]", string.Join(",",TwoSumProb.TwoSum(nums, target)));
  // Test case 1 
        //int[] nums = new int[]{2,7,11,15}; target = 9
        //Test case 2
        //int[] nums = new int[]{3,2,4}; target = 6
        //Test case 3
       // int[] nums = [3,3]; target = 6

// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 

// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]


// Constraints:

// 2 <= nums.length <= 104
// -109 <= nums[i] <= 109
// -109 <= target <= 109
// Only one valid answer exists.
 

// Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?


// TC = 134ms 66.26%
// SC = 47.49 MB 28.21%