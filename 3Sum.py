class Solution:
    #O(n) time and O(1) space
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        res = []
        nums.sort()
        for i, a in enumerate(nums):
            if i>0 and a==nums[i-1]:
                continue
            l , r = i+1, len(nums)-1
            while l < r:
                sum = a+nums[l]+nums[r]
                if sum>0:
                    r-=1
                elif sum<0:
                    l+=1
                else:
                    res.append([a,nums[l],nums[r]])
                    l+=1
                    while l<r and nums[l]==nums[l-1]:
                        l+=1
        return res

# Time complexity: O(n^3)
# Space complexity: O(1)
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        result = set()
        nums.sort()
        final = []
        for i in range(len(nums)):
            for j in range(i+1,len(nums)):
                for k in range(j+1,len(nums)):
                    threeSum = nums[i]+nums[j]+nums[k]
                    if threeSum == 0:
                        result.add(tuple(sorted([nums[i],nums[j],nums[k]])))
        return [list(item) for item in result]
                        
            
                