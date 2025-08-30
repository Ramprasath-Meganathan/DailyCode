class Solution:
    def searchRange(self, nums: List[int], target: int) -> List[int]:
      #O(n) time and O(1) space
      first = -1
      n = len(nums)
      last = -1
      for i in range(n):
        if nums[i] == target:
            if first == -1:
                first = i
            last = i
      return [first, last]

    #O(logn) time and O(1) space
    def searchRange(self, nums: List[int], target: int) -> int:
     #find first
     def findFirst(nums,target)->List[int]:
        l,r,ans = 0,len(nums)-1,-1
        while l <=r:
            mid = l+(r-l)//2
            if nums[mid]>=target:
                if nums[mid]==target:
                    ans = mid
                r = mid-1
            elif nums[mid]<target:
                l = mid+1
        return ans

     def findLast(nums,target)->int:
        l,r,ans = 0,len(nums)-1,-1
        while l <=r:
            mid = l+(r-l)//2
            if nums[mid]>target:
                r=mid-1
            elif nums[mid]<=target:
                if nums[mid]==target:
                    ans = mid
                l=mid+1
        return ans
    
     return [findFirst(nums,target),findLast(nums,target)]
    

#Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

# If target is not found in the array, return [-1, -1].

# You must write an algorithm with O(log n) runtime complexity.

   
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