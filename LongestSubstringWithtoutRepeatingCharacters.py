class Solution:
    def lengthOfLongestSubstringBruteForce(self, s: str) -> int:
        res  = 0 #O(1) time and O(1) space
        for i in range(len(s)):  #O(n) time and O(1) space
            charSet = set()  #O(1) time and O(n) space
            for j in range(i, len(s)):  #O(n) time and O(1) space
                if s[j] in charSet:  #O(1) time and O(1) space
                    break #O(1) time and O(1) space
                charSet.add(s[j])  #O(1) time and O(1) space
            res = max(res,len(charSet))  #O(1) time and O(1) space
        return res  #O(1) time and O(1) space

    #O(n) time and O(m) space where m is the maximum size of substring
    def lengthOfLongestSubstring(self, s: str) -> int:
        res = 0 #O(1) time and O(1) space
        charSet = set() #O(1) time and O(m) space
        l=0 #O(1) time and O(1) space
        for r in range(len(s)): #O(n) time and O(1) space
            while s[r] in charSet: #O(n) time and O(1) space
                charSet.remove(s[l]) #O(1) time and O(1) space
                l+=1 #O(1) time and O(1) space
            charSet.add(s[r]) #O(1) time and O(1) space
            res = max(res,r-l+1) #O(1) time and O(1) space
        return res #O(1) time and O(1) space