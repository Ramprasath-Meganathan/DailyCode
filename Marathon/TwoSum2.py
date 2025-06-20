    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        #O(n2) time and O(1) space
        for i in range(0,len(numbers)):
            for j in range(i+1,len(numbers)):
                if numbers[i]+numbers[j] == target:
                    return [i+1,j+1]
                    
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        #O(n) time and O(1) space
        if len(nums) <=1:
            return []
        l, r= 0, len(nums)-1
        while l<r:
            actualValue = nums[l]+nums[r]
            if actualValue == target:
                return [l+1,r+1]
            elif actualValue > target:
                r-=1
            else:
                l+=1
        
        