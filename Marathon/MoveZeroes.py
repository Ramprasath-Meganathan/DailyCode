class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        #O(n) time and O(1) space
        #Two pointers approach
        #l is the position to place the next non-zero element
        #r is the current element being checked
        #If nums[r] is non-zero, swap it with nums[l] and increment l
        n = len(nums)
        l=0
        for r in range(n):
            if nums[r]:
                nums[l],nums[r] = nums[r],nums[l]
                l+=1