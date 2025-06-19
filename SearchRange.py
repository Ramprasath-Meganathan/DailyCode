class Solution:
    #LeetCode 34. Find First and Last Position of Element in Sorted Array
    #https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    def searchRange(self, nums: List[int], target: int) -> List[int]:
        #O(n) time and O(1) space
        first_index, last_index = -1, -1
        for i,val in enumerate(nums):
                if val == target :
                    if first_index ==-1:
                        first_index = i
                    last_index = i
        return [first_index,last_index]
    
     #O(logn) time and O(1) space
        def findFirst(nums,target):
            l,r=0,len(nums)-1
            first = -1
            while l<=r:
                mid = (l+r)//2
                if target==nums[mid]:
                    first= mid
                    r= mid-1
                elif target<nums[mid]:
                    r = mid-1
                else:
                    l=mid+1
            return first
        
        def findLast(nums,target):
            last = -1
            l,r=0,len(nums)-1
            while l<=r:
                mid = (l+r)//2
                if target==nums[mid]:
                    last= mid
                    l= mid+1
                elif target<nums[mid]:
                    r = mid-1
                else:
                    l=mid+1
            return last
        
        return  [findFirst(nums,target),findLast(nums,target)]

    
# Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

# If target is not found in the array, return [-1, -1].

# You must write an algorithm with O(log n) runtime complexity.
# explore bisect module for binary search
 

# Example 1:

# Input: nums = [5,7,7,8,8,10], target = 8
# Output: [3,4]
# Example 2:

# Input: nums = [5,7,7,8,8,10], target = 6
# Output: [-1,-1]
# Example 3:

# Input: nums = [], target = 0
# Output: [-1,-1]
 

# Constraints:

# 0 <= nums.length <= 105
# -109 <= nums[i] <= 109
# nums is a non-decreasing array.
# -109 <= target <= 109