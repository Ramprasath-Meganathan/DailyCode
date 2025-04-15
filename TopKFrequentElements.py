class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        #O(nlogn+k) time and O(n+k) space
        frequencyDict = {} #O(1) time and O(n) space where n is the number of elements in the list
        for num in nums: # O(n) time and O(1) space
            frequencyDict[num] = 1+frequencyDict.get(num,0) #O(1) time and O(1) space
        top_two = sorted(frequencyDict.items(), key=lambda item:item[1], reverse=True) #O(nlogn) time for sorting and O(n) space
        top_k_values= [] #O(k) space
        for i in range(k): #O(k) time and O(1) space
            key = top_two[i][0] #O(1) time and space
            top_k_values.append(key) #O(1) time and space
        return top_k_values #O(1) time and space

    #O(nlogn+k) time and O(n+k) space
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        frequencyDict = {} #O(1) time and O(n) space where n is the number of elements in nums

        # Form the frequency Dictionary
        for num in nums: #O(n) time and O(1) space 
            frequencyDict[num] = 1+frequencyDict.get(num,0) #O(1) time and O(1) space
        
        #put the values in a list and sort them in descending order
        frequencyListDesc = [] #O(1) time and O(n) space
        for num,count in frequencyDict.items(): #O(n) time and O(1) space
            frequencyListDesc.append([count,num]) #O(1) time and O(1) space
        frequencyListDesc.sort(reverse=True) #O(nlogn) time and O(n) space

        #get the k elements from the list
        result=[] #O(1) time and O(k) space
        for i in range(k): #O(k) time and O(1) space
            result.append(frequencyListDesc[i][1]) #O(1) time and O(1) space
        return result #O(1) time and O(1) space
    
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        #O(n*logk) time and O(n+k) space
        frequencyDict = {} #O(1) time and O(n) space
        for num in nums: #O(n) time and O(1) space
            frequencyDict[num] = 1+frequencyDict.get(num,0) #O(1) time and O(1) space
        
        heap = [] # O(1) time and O(k) space
        for num in frequencyDict.keys(): #O(n) time and O(1) space
            heapq.heappush(heap,(frequencyDict[num],num)) #O(logk) time and O(1) space
            if len(heap)>k: #O(1) time and O(1) space
                heapq.heappop(heap) #O(1) time and O(1) space
        
        result = [] #O(1) time and O(k) space
        for i in range(k): #O(k) time and O(1) space
            result.append(heapq.heappop(heap)[1]) #O(klogk) time and O(1) space
        return result #O(1) time and O(1) space