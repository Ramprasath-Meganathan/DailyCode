class Solution:
    #dictionary approach
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        #O(n+klogk) time and O(k) space
        frequencyDict= {}
        for num in nums: #O(n) time and O(k) space where k is the no of unique el
            frequencyDict[num] = 1+frequencyDict.get(num,0)
        reversedDict = dict(sorted(frequencyDict.items(), key = lambda x:x[1],reverse=True)) #O(klogk) time where k is the number of unique keys
        return list(islice(reversedDict.keys(),k)) #O(k) time and O(k) space

    #heap based approach 
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        #O(n+klogk) time and O(k) space
        frequencyDict= {}
        min_heap = []
        for num in nums: #O(n) time and O(k) space where k is the no of unique el
            frequencyDict[num] = 1+frequencyDict.get(num,0)

        for key,value in frequencyDict.items():
            heapq.heappush(min_heap,(value,key))
            if len(min_heap)>k:
                heapq.heappop(min_heap)
            
        return [key for _,key in min_heap]