    def twoSum(self, nums: List[int], target: int) -> List[int]:
        # Brute Force Approach
        #O(n2) time and O(1) space 
        for i in range(len(nums)-1):
            for j in range(i+1,len(nums)):
                if nums[i]+nums[j] == target:
                    return [i,j]
        
    # HashMap Approach
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        #O(n) time and O(n) space
        hashMap = {} #O(n) space
        length = len(nums)
        for i in range(length): #O(n) time 
            currentElement = nums[i]
            elementToSearch = target - currentElement
            if elementToSearch in hashMap:
                return [i,hashMap[elementToSearch]] 
            hashMap[currentElement] = i