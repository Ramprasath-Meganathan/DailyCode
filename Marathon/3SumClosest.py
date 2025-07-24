class Solution:
    # O(n^2) time and O(n) space
    def threeSumClosest(self, nums: List[int], target: int) -> int:
        nums.sort()
        closest = float('inf')
        n = len(nums)
        for i,a in enumerate(nums):
            if i > 0 and nums[i]==nums[i-1]:
                continue
            lo, hi = i+1,len(nums)-1
            while lo<hi:
                current_sum = a+nums[lo]+nums[hi]
                if abs(target-current_sum) < abs(target-closest):
                    closest = current_sum
                if current_sum < target:
                    lo+=1
                elif current_sum>target:
                    hi-=1
                else:
                    return current_sum
        return closest

# 16. 3Sum Closest

# Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

# Return the sum of the three integers.

# You may assume that each input would have exactly one solution.

 

# Example 1:

# Input: nums = [-1,2,1,-4], target = 1
# Output: 2
# Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
# Example 2:

# Input: nums = [0,0,0], target = 1
# Output: 0
# Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
 

# Constraints:

# 3 <= nums.length <= 500
# -1000 <= nums[i] <= 1000
# -104 <= target <= 104