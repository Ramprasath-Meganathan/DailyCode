public class MoveZeroesProgram {
    // O(n) time and O(1) space
    public void MoveZeroes(int[] nums) { 
        int i = 0;       
        int j =  nums.Length>1 ? 1:0;
        while(j<=nums.Length-1)
        {
            if(nums[i]==0)
            {
                if(nums[j]!=0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                }
            }
            else
                i++;
            j++;
        }
    }
}

// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

// Note that you must do this in-place without making a copy of the array.

 

// Example 1:

// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]
// Example 2:

// Input: nums = [0]
// Output: [0]
 

// Constraints:

// 1 <= nums.length <= 104
// -231 <= nums[i] <= 231 - 1
 

// Follow up: Could you minimize the total number of operations done?