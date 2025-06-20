class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        #O(n*maxk) time and O(1) space
        maxk = max(piles)
        for k in range(1,maxk+1):
            totalHours = 0
            for pile in piles:
                totalHours+=ceil(pile/k)
            if totalHours<=h:
                return k
            
    #O(n*log(maxk)) time and O(1) space    
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
       l,r = 1, max(piles)
       res = r
       while l <=r:
        totalHours = 0
        k = (l+r)//2
        for pile in piles:
            totalHours+=ceil(float(pile)/k)
        if totalHours<=h:
            res = k
            r=k-1
        else:
            l=k+1
       return res