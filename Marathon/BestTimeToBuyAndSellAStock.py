class Solution:
    def maxProfit(self, s: List[int]) -> int:
      #O(n2) time and O(1) space
       max_profit = 0
       if len(s)==1:
            return 0 
       for i in range(len(s)): #buy price
            for j in range(i+1,len(s)): #sell price
                if s[i]<s[j]: # if buy price is less than sell price
                    current_profit = s[j]-s[i]
                    max_profit = max(current_profit,max_profit) #update the maximum profit
       return max_profit

    def maxProfit(self, s: List[int]) -> int:
      #O(n) time and O(1) space
       max_profit = 0
       n= len(s)
       if n==1:
            return 0 
       lo,hi = 0,1
       while lo < hi:
            if s[lo]<s[hi]:
                current_profit = s[hi]-s[lo]
                max_profit = max(current_profit,max_profit)
                r+=1
            else:
                l=r
       return max_profit  