class Solution:
    #O(n+klogk) where k is the number of unique elements and O(n+k) space
    def frequencySort(self, nums: List[int]) -> List[int]:
        freqDict = {}
        res = []
        for num in nums: #O(n) time
            freqDict[num] = 1+freqDict.get(num,0) #O(klogk) space where k is the number of unique elements
        sortedDict = sorted(freqDict.items(),key=lambda x:(x[1],-x[0])) #O(k) time and O(k) space
        for k,v in sortedDict: #O(n) time
            for i in range(v): 
                res.append(k)
        return res