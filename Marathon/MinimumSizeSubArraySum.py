class Solution:
    #Brute force approach
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        #O(n2) time and O(1) space
        min_size = float('inf') #declaring min_size as maximum value since we are finding minimum
        n = len(nums)
        for i in range(n): #for identifying the starting point of the array
            curr_sum = 0
            for j in range(i,n): # Loop to compute the sum of the subarray starting at index i.
                curr_sum+=nums[j]
                if curr_sum>=target:
                    min_size = min(j-i+1,min_size)
                    break
        return 0 if min_size == float('inf') else min_size
    
    #Sliding window approach
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
            #O(n) time and O(1) space
            min_size = float('inf') #declaring min_size as maximum value since we are finding minimum
            n = len(nums)
            l = 0
            curr_sum = 0
            for r in range(n):
                curr_sum+=nums[r]
                while curr_sum >= target:
                    min_size = min(r-l+1,min_size)
                    curr_sum-=nums[l]
                    l+=1
            return 0 if min_size == float('inf') else min_size

# 209. Minimum Size Subarray Sum         
# Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.


# Example 1:

# Input: target = 7, nums = [2,3,1,2,4,3]
# Output: 2
# Explanation: The subarray [4,3] has the minimal length under the problem constraint.
# Example 2:

# Input: target = 4, nums = [1,4,4]
# Output: 1
# Example 3:

# Input: target = 11, nums = [1,1,1,1,1,1,1,1]
# Output: 0
 

# Constraints:

# 1 <= target <= 109
# 1 <= nums.length <= 105
# 1 <= nums[i] <= 104
 

# Follow up: If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log(n)).
