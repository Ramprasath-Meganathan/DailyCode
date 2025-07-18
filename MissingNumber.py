class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        return sum(range(len(nums)+1)) - sum(nums)
    
    #O(nlogn) time and O(n) space - sorted and and new list is created
    def missingNumber(self, nums: List[int]) -> int:
        nums = sorted(nums)
        for i in range(len(nums)):
            if nums[i] !=i:
                return i
        return len(nums)
    
     #O(nlogn) time and O(n) space
    def missingNumber(self, nums: List[int]) -> int:
        nums.sort()
        for i in range(len(nums)):
            if nums[i] !=i:
                return i
        return len(nums)

    def missingNumber(self, nums: List[int]) -> int:
        numSet = set(nums)
        for i in range(len(nums)):
            if i not in numSet:
                return i
        return len(nums)

    #O(n) time and O(1) space
    # using mathematical formula

    def missingNumber(self, nums: List[int]) -> int:
        res = len(nums)
        for i in range(len(nums)):
            res +=i-nums[i]
        return res
    
    #O(n) time and O(1) spac
    def missingNumber(nums):
        n = len(nums)
        return n * (n + 1) // 2 - sum(nums)
    
    #O(n) time and O(1) space
    # using bit manipulation
    def missingNumber(self, nums: List[int]) -> int:
        n = len(nums)
        xorr = n
        for i in range(n):
            xorr ^= i^nums[i]
        return xorr

# O(n) time and O(1) space
# 268 Missing Number
# Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

# Example 1:

# Input: nums = [3,0,1]

# Output: 2

# Explanation:

# n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

# Example 2:

# Input: nums = [0,1]

# Output: 2

# Explanation:

# n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.

# Example 3:

# Input: nums = [9,6,4,2,3,5,7,0,1]

# Output: 8

# Explanation:

# n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.

# Constraints:

# n == nums.length
# 1 <= n <= 104
# 0 <= nums[i] <= n
# All the numbers of nums are unique.
 
# Follow up: Could you implement a solution using only O(1) extra space complexity and O(n) runtime complexity?

