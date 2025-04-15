class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        #O(n) time and O(n) space
        sumDict = {} #O(1) time and O(n) space
        for i,v in enumerate(nums): #O(n) time and O(1) space
            diff = target - v # O(1) time and O(1) space
            if diff in sumDict: #O(1) time and O(1) space
                return sumDict[diff],i #O(1) time and O(1) space
            sumDict[v] = i #O(1) time and O(1) space
            
    def twoSum(self, nums: List[int], target: int) -> List[int]:
            #O(n) time and O(n) space
           sumDict = {} #O(1) time and O(n) space
            for i,n in enumerate(nums): #O(n) time and O(1) space
                sumDict[n] = i #O(1) time and O(1) space
            for i,n in enumerate(nums): #O(n) time and O(1) space
                difference = target - n #O(1) time and O(1) space
                if difference in sumDict and sumDict[difference]!=i: #O(1) time and O(1) space
                    return [i, sumDict[difference]]  #O(1) time and O(1) space
                     
    def twoSumn2(self, nums: List[int], target: int) -> List[int]:
            #O(n2) time and O(1) space
        for i in range(len(nums)-1): # O(n) time and O(1) space
            for j in range(i+1,len(nums)): # O(n) time and O(1) space
                if(nums[i]+nums[j]==target): #O(1) time and O(1) space
                    return [i,j] #O(1) time and space
        return [] # O(1) time and space
            
        

        