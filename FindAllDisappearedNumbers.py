class Solution:
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:
        set_nums = set(nums)
        ret = []

        for i in range(1,len(nums)+1):
            if i not in set_nums:
                ret.append(i)
        return ret

    #O(n2) time and O(k) space where k is the number of disappearing elements
    # using set to find missing numbers
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:
        res = []
        for i in range(1,len(nums)+1):
            if i not in nums:
                res.append(i)
        return res
    
    #using Hashset
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:
        #O(n) time and O(n) space
        res = []
        numsSet = set(nums) #O(n) space
        n = len(nums)
        for i in range(1, n+1): #O(n) time 
            if i not in numsSet:
                res.append(i)
        return res
    
    #O(n) time and O(1) space
    # using index marking
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:
        res = []
        for num in nums:
            index = abs(num)-1
            nums[index] = -1* abs(nums[index])
        for i,a in enumerate(nums):
            if a>0:
                res.append(i+1)
        return res
     

# O(n) time and space
# 448. Find All Numbers Disappeared in an Array
# Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
# Example 1:

# Input: nums = [4,3,2,7,8,2,3,1]
# Output: [5,6]
# Example 2:

# Input: nums = [1,1]
# Output: [2]
 

# Constraints:

# n == nums.length
# 1 <= n <= 105
# 1 <= nums[i] <= n
 

# Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.