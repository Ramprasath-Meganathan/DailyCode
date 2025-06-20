class Solution:
    def findMin(self, nums: List[int]) -> int:
        #O(logn) time and O(1) space
        l,r = 0, len(nums)-1
        while l<r:
            mid = (l+r)//2
            if nums[mid]>nums[r]:
                l+=1
            else:
                r=mid
        return nums[l]