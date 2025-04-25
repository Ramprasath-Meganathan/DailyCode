class Solution:
    #O(n2) time and O(1) space
    def maxProfitBruteForce(self, prices: List[int]) -> int:
        maxProfit = 0 #O(1) time and O(1) space
        for i in range(len(prices)): #O(n) time and O(1) space
            for j in range(i+1,len(prices)): #O(n) time and O(1) space
                profit = prices[j]-prices[i] #O(1) time and O(1) space
                maxProfit = max(maxProfit, profit) #O(1) time and O(1) space
        return maxProfit #O(1) time and O(1) space

    
        #O(n) time and O(1) space
    def maxProfitTwoPointerHashSet(self, prices: List[int]) -> int:
        maxProfit = 0 #O(1) time and O(1) space
        l,r = 0, 1 #O(1) time and O(1) space
        while r<len(prices): #O(n) time and O(1) space
            if prices[l]<prices[r]: #O(1) time and O(1) space
                profit = prices[r]-prices[l] #O(1) time and O(1) space
                maxProfit = max(profit,maxProfit) #O(1) time and O(1) space
            else: #O(1) time and O(1) space
                l=r #O(1) time and O(1) space
            r+=1 #O(1) time and O(1) space
        return maxProfit #O(1) time and O(1) space
    
        #O(n) time and O(m) space where m is the maximum size of substring
    def lengthOfLongestSubstringDict(self, s: str) -> int:
        res = 0 #O(1) time and O(1) space
        subDict = {} #O(1) time and O(m) space
        l = 0 #O(1) time and O(1) space
        for r in range(len(s)): #O(n) time and O(1) space
            if s[r] in subDict: #O(1) time and O(1) space
                l = max(subDict[s[r]]+1,l) #O(1) time and O(1) space
            subDict[s[r]] = r #O(1) time and O(1) space
            res = max(res,r-l+1) #O(1) time and O(1) space
        return res #O(1) time and  O(1) space
