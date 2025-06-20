class Solution:
    #Brute force solution
    def search(self, nums: List[int], target: int) -> int:
        #O(n) time and O(1) space
        for i in range(len(nums)):
            if nums[i] == target:
                return i
        return -1
    #Binary search solution
    def search(self, nums: List[int], target: int) -> int:
         #O(logn) and O(1) time and space
        #find min_index
        l,r = 0, len(nums)-1
        while l<r:
            mid = (l+r)//2
            if nums[mid]>nums[r]:
                l=mid+1
            else:
                r=mid
        min_index = l

        if min_index == 0:
            l,r = 0,len(nums)-1
        elif target >= nums[0] and target<=nums[min_index-1]:
            l,r = 0,min_index-1
        else:
            l,r = min_index,len(nums)-1 
        
        while l<=r:
            mid = (l+r)//2
            if target == nums[mid]:
                return mid
            elif nums[mid]<target:
                l=mid+1
            else:
                r=mid-1
        return -1
