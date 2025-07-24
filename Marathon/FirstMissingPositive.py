class Solution:
    #O(n) time and O(1) space
    def firstMissingPositive(self, nums: List[int]) -> int:
        n = len(nums)
        for i in range(n):
            if nums[i]<0:
                nums[i]=0
        for i in range(n):
            val = abs(nums[i])
            if 1 <= val<= n:
                idx = val-1
                if nums[idx]>0:
                    nums[idx]= -1*nums[idx]
                elif nums[idx]==0:
                    nums[idx] = -1*(n+1)
        for i in range(1,len(nums)+1):
            if nums[i-1] >=0:
                return i
        return n+1

# 41. First Missing Positive
# Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.

# You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

 

# Example 1:

# Input: nums = [1,2,0]
# Output: 3
# Explanation: The numbers in the range [1,2] are all in the array.
# Example 2:

# Input: nums = [3,4,-1,1]
# Output: 2
# Explanation: 1 is in the array but 2 is missing.
# Example 3:

# Input: nums = [7,8,9,11,12]
# Output: 1
# Explanation: The smallest positive integer 1 is missing.
 

# Constraints:

# 1 <= nums.length <= 105
# -231 <= nums[i] <= 231 - 1
        


