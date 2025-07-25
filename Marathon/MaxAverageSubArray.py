class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:
       #O(n*k) time and O(1) space
       max_average = float('-inf')
       n = len(nums)
       for i in range(n-k+1): # # loop over all starting points for subarrays of length k
            current_sum = 0
            for j in range(i,i+k): # Sum up elements of the current subarray of length k. 
                current_sum +=nums[j]
            max_average = max(max_average,(current_sum/k))
       return max_average
    
    #two pointer approach
    def findMaxAverage(self, nums: List[int], k: int) -> float:
       #O(n) time and O(1) space
       n = len(nums)
       curr_sum  = 0
       for i in range(k):
            curr_sum+=nums[i]
       max_avg = curr_sum/k
       l = 0
       for r in range(k,n):
            curr_sum+=nums[r]-nums[l]
            l+=1
            max_avg = max(curr_sum/k,max_avg)
       return max_avg


        
# 643. Maximum Average Subarray I   
# You are given an integer array nums consisting of n elements, and an integer k.

# Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

# Example 1:

# Input: nums = [1,12,-5,-6,50,3], k = 4
# Output: 12.75000
# Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
# Example 2:

# Input: nums = [5], k = 1
# Output: 5.00000
 

# Constraints:

# n == nums.length
# 1 <= k <= n <= 105
# -104 <= nums[i] <= 104