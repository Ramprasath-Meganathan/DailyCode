class Solution:
    def isAnagramUsingHashMap(self, s: str, t: str) -> bool:
        # O(n+m) time and O(n+m) space
        if len(s)!=len(t): #O(n) time and O(1) space
            return False # O(1) ts
        sdict,tdict={},{} #O(n+m) ts
        for i in range(len(s)): # O(n) time and O(1) space
            sdict[s[i]] = 1+sdict.get(s[i],0) # O(1) ts
            tdict[t[i]] = 1+tdict.get(t[i],0) # O(1) ts
        return sdict == tdict # O(1) ts
    
        def isAnagramOptimized(self, s: str, t: str) -> bool:
        #O(nlogn+mlogm) time and O(1) space
        # O(n+m) time and O(n+m) space
        if len(s)!=len(t): #O(1) ts
            return False # O(1) ts
        return sorted(s) == sorted(t) #O(nlogn+mlogm) time 
    
       def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t): # O(1) time and space
            return False # O(1) time and space
        freqMap = [0] * 256 # O(1) time and O(256) space
        for i in range(len(s)): # O(n) time and O(1) space
            freqMap[ord(s[i])-ord('a')]+=1 # O(1) time and O(1) space
        for i in range(len(t)): # O(n) time and O(1) space
            freqMap[ord(t[i])-ord('a')]-=1  # O(1) time and O(1) space
            if freqMap[ord(t[i])-ord('a')]<0:  # O(1) time and O(1) space
                return False  # O(1) time and O(1) space
        return True  # O(1) time and O(1) space



