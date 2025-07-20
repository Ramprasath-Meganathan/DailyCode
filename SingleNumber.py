class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        #O(n) time and O(k) space where k is the number of unique elements in dict
        numDict = {}
        for num in nums:
            numDict[num] = 1+numDict.get(num,0)
        for k,v in numDict.items():
            if v==1:
                return k

    from collections import Counter
    def singleNumber(self, nums: List[int]) -> int:
        #O(n) time and O(k) space where k is the number of unique elements in dict
        numDict = Counter(nums)
        for k,v in numDict.items():
            if v==1:
                return k
    
    #O(n) time and O(k) space
    from collections import Counter
    def singleNumber(self, nums: List[int]) -> int:
        #O(n) time and O(k) space where k is the number of unique elements in dict
        numDict = Counter(nums)
        return next(num for num,freq in numDict.items() if freq==1)
    
    #O(n) time and O(1) space
    def singleNumber(self, nums: List[int]) -> int:
        res = 0
        for num in nums:
            res^=num
        return res