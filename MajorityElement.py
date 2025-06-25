class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        #O(n) time and O(n) space
        frequencyDict = {}
        for i,a in enumerate(nums):
            frequencyDict[a] = 1+frequencyDict.get(a,0)
        sortByValue = max(frequencyDict, key = frequencyDict.get)
        return sortByValue
            
            #O(n) time and O(1) space
        def majorityElement(self, nums: List[int]) -> int:
            candidate,count = None,0
            for num in nums:
                if count == 0:
                    candidate = num
                    count = 1
                elif candidate == num:
                    count+=1
                else:
                    count-=1          
            return candidate
