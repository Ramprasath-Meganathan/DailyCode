class Solution:
    #O(nlogn) time and O(n) space
    def sortedSquares(self, nums: List[int]) -> List[int]:
        for i in range(len(nums)):
            nums[i] = nums[i]**2
        nums.sort()
        return nums

    #using two pointer approach
    def sortedSquares(self, nums: List[int]) -> List[int]:
        #O(n) time and O(1) space
        n = len(nums)
        res = [0]*n
        l,r = 0,n-1
        pos=n-1
        while l <=r:
            if abs(nums[l])>=abs(nums[r]):
                res[pos] = nums[l]**2
                l+=1
            else:
                res[pos]= nums[r]**2
                r-=1
            pos-=1
        return res

# 977. Squares of a Sorted Array
# Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

# Example 1:

# Input: nums = [-4,-1,0,3,10]
# Output: [0,1,9,16,100]
# Explanation: After squaring, the array becomes [16,1,0,9,100].
# After sorting, it becomes [0,1,9,16,100].
# Example 2:

# Input: nums = [-7,-3,2,3,11]
# Output: [4,9,9,49,121]
 

# Constraints:

# 1 <= nums.length <= 104
# -104 <= nums[i] <= 104
# nums is sorted in non-decreasing order.
 

# Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?