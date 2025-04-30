class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        #O(n2) time and O(1) space
        res = 0 #O(1) time and O(1) space
        for i in range(len(s)):    #O(n) time and O(1) space
            count,maxf = {},0 #O(1) time and O(1) space
            for j in range(i,len(s)): #O(n) time and O(1) space
                count[s[j]] = 1+count.get(s[j],0)  #O(1) time and O(1) space
                maxf = max(maxf,count[s[j]]) #O(1) time and O(1) space
                if(j-i+1) - maxf <=k: #O(1) time and O(1) space
                    res = max(res,j-i+1) #O(1) time and O(1) space
        return res #O(1) time and O(1) space