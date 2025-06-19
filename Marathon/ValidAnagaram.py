class Solution:
    #sorting solution
    def isAnagram(self, s: str, t: str) -> bool:
        #O(nlogn time) and O(n) space
        if len(s)!=len(t):
            return False
        return sorted(s) == sorted(t) #O(nlogn) time and O(n) space and O(n) time for comparison
    
    #HashMap solution
     def isAnagram(self, s: str, t: str) -> bool:
        sLength = len(s) #O(1) time and O(1) space
        tLength = len(t) #O(1) time and O(1) space
        sMap,tMap = {}, {} #O(1) time and O(1) space
        if sLength != tLength: #O(1) time and O(1) space
            return False #O(1) time and O(1) space
        for i in range(sLength): #O(n) time and O(n) space
            sMap[s[i]] = 1+sMap.get(s[i],0) #O(1) time and O(1) space
            tMap[t[i]] = 1+tMap.get(t[i],0) #O(1) time and O(1) space
        return sMap == tMap #O(n) time and O(1) space


    